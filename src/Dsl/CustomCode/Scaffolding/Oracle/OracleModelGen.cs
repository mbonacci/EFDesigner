using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Modeling;

namespace Sawczyn.EFDesigner.EFModel.ModelGen
{
    public class OracleModelGen : ModelGenerator
    {
        private DbConnection con;

        public OracleModelGen(Store store, DSRefAdapter dsRef) : base(store, dsRef)
        {
            DbProviderFactory pf = DbProviderFactories.GetFactory("Oracle.ManagedDataAccess.Client");
            con = pf.CreateConnection();
            ModelRoot modelRoot = store.ElementDirectory.AllElements.OfType<ModelRoot>().FirstOrDefault();
            con.ConnectionString = modelRoot.ConnectionString;
            con.Open();
        }

        protected override GenProc GetProcInfo()
        {
            GenProc p = new GenProc();
            p.Schema = schema;

            string[] np = name.Split('.');
            if (np.Length == 1)
                p.Name = name;
            else if (np.Length == 2) {
                p.Name = np[1];
                p.PackageName = np[0];
            }

            p.IsFunction = false;
            DbCommand cmd = con.CreateCommand();
            cmd.CommandText = $@"select * 
                                from ALL_ARGUMENTS 
                                where package_name = '{ p.PackageName ?? "NULL" }'
                                and object_name = '{ p.Name }'";
            DbDataReader r = cmd.ExecuteReader();
            while (r.Read()) {
                if (r.GetInt32(7) == 0) {
                    p.IsFunction = true;
                    p.ReturnDbType = r.GetString(24);
                    p.ReturnType = GetCLRType(p.ReturnDbType, 256, r.IsDBNull(17) ? 0 : r.GetInt32(17), r.IsDBNull(16) ? 0 : r.GetInt32(16));
                } else if (!r.IsDBNull(6)) {
                    GenParam pp = new GenParam() {
                        Name = r.GetString(6),
                        Index = r.IsDBNull(7) ? 1 : r.GetInt32(7),
                        DbType = r.IsDBNull(24) ? null : r.GetString(24),
                        Length = r.IsDBNull(25) ? 0 : r.GetInt32(25),
                        Precision = r.IsDBNull(16) ? 0 : r.GetInt32(16),
                        Scale = r.IsDBNull(17) ? 0 : r.GetInt32(17),
                        Direction = r.IsDBNull(14) ? null : r.GetString(14),
                        Required = r.IsDBNull(11) ? false : r.GetString(11) == "N"
                    };
                    pp.Type = GetCLRType(pp.DbType, pp.Length, pp.Scale, pp.Precision);
                    p.Params.Add(pp);
                }
            }

            return p;
        }

        protected override GenClass GetTableInfo()
        {
            GenClass p = new GenClass();
            p.Schema = schema;
            p.Name = name;

            DbCommand cmd = con.CreateCommand();
            cmd.CommandText = $@"select * 
                                from ALL_TAB_COLUMNS 
                                where table_name = '{ p.Name }'";
            DbDataReader r = cmd.ExecuteReader();
            while (r.Read()) {
                if (!r.IsDBNull(2)) {
                    GenColumn pp = new GenColumn() {
                        Name = r.GetString(2),
                        Index = r.IsDBNull(10) ? 1 : r.GetInt32(10),
                        DbType = r.IsDBNull(3) ? null : r.GetString(3),
                        Length = r.IsDBNull(6) ? 0 : r.GetInt32(6),
                        Precision = r.IsDBNull(7) ? 0 : r.GetInt32(7),
                        Scale = r.IsDBNull(8) ? 0 : r.GetInt32(8),
                        Required = r.IsDBNull(9) ? false : r.GetString(9) == "N"                        
                    };
                    pp.Type = GetCLRType(pp.DbType, pp.Length, pp.Scale, pp.Precision);
                    p.Columns.Add(pp);
                }
            }

            cmd.CommandText = $@"select cc.* 
                                from ALL_CONSTRAINTS c left join 
                                    ALL_CONS_COLUMNS cc on cc.constraint_name = c.constraint_name and cc.table_name = c.table_name
                                where C.TABLE_NAME = '{ p.Name }' and C.CONSTRAINT_TYPE = 'P'";
            r = cmd.ExecuteReader();
            while (r.Read()) {
                if (!r.IsDBNull(3)) {
                    GenColumn c = p.Columns.FirstOrDefault(i => i.Name == r.GetString(3));
                    c.IsPrimaryKey = true;
                    c.PrimaryKeyIndex = r.GetInt32(4);
                }
            }

            return p;
        }

        protected override GenClass GetViewInfo()
        {
            GenClass p = new GenClass();
            p.Schema = schema;
            p.Name = name;

            DbCommand cmd = con.CreateCommand();
            cmd.CommandText = $@"select * 
                                from ALL_TAB_COLUMNS 
                                where table_name = '{ p.Name }'";
            DbDataReader r = cmd.ExecuteReader();
            while (r.Read()) {
                if (!r.IsDBNull(2)) {
                    GenColumn pp = new GenColumn() {
                        Name = r.GetString(2),
                        Index = r.IsDBNull(10) ? 1 : r.GetInt32(10),
                        DbType = r.IsDBNull(3) ? null : r.GetString(3),
                        Length = r.IsDBNull(6) ? 0 : r.GetInt32(6),
                        Precision = r.IsDBNull(7) ? 0 : r.GetInt32(7),
                        Scale = r.IsDBNull(8) ? 0 : r.GetInt32(8),
                        Required = r.IsDBNull(9) ? false : r.GetString(9) == "N"
                    };
                    pp.Type = GetCLRType(pp.DbType, pp.Length, pp.Scale, pp.Precision);
                    p.Columns.Add(pp);
                }
            }
            return p;
        }

        protected string GetCLRType(string dbType, int length, int scale, int precision)
        {
            switch (dbType.ToLower()) {
                case "number":
                    if (scale == 0) {
                        if (precision < 10) return "Int32";
                        return "Int64";
                    } else
                        return "Decimal";
                case "varchar2":
                case "char":
                case "nchar":
                case "nvarchar2":
                    return "String";
                case "date":
                    return "DateTime";
            }

            return "String";
        }
    }
}
