using Microsoft.VisualStudio.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawczyn.EFDesigner.EFModel.ModelGen
{
    public abstract class ModelGenerator
    {
        protected string conString;
        protected string schema;
        protected string name;
        protected Store store;

        public ModelGenerator(Store store, DSRefAdapter dsRef)
        {
            conString = dsRef.ConString;
            schema = dsRef.Schema;
            name = dsRef.Name;
            this.store = store;
        }

        public static bool GenerateItem(Store store, DSRefAdapter dsRef)
        {
            ModelGenerator gen = null;
            switch (dsRef.Provider) {
                case "oracle":
                    gen = new OracleModelGen(store, dsRef);
                    break;
            }

            bool res = false;
            if (gen != null) {
                Transaction tx = store.TransactionManager.CurrentTransaction == null
                        ? store.TransactionManager.BeginTransaction()
                        : null;

                try {
                    switch (dsRef.Type) {
                        case DSRefType.Table:
                            res = gen.GenerateClass(gen.GetTableInfo());
                            break;
                        case DSRefType.View:
                            res = gen.GenerateClass(gen.GetViewInfo());
                            break;
                        case DSRefType.Procedure:
                            res = gen.GenerateProc(gen.GetProcInfo());
                            break;
                    }
                } catch {
                    tx = null;
                    throw;
                } finally {
                    tx?.Commit();
                }
            }
            return res;
        }

        private string MakeIdent(string name, bool firstUpper)
        {
            bool lower = !firstUpper;
            string res = "";
            foreach (char c in name) {
                if (c == '_' || c == '-') {
                    lower = false;
                } else {
                    res += lower ? char.ToLower(c) : char.ToUpper(c);
                    lower = true;
                }
            }
            return res;
        }

        public bool GenerateClass(GenClass cls)
        {
            ModelRoot modelRoot = store.ElementDirectory.AllElements.OfType<ModelRoot>().FirstOrDefault();

            ModelClass mp = new ModelClass(store, new PropertyAssignment(ModelClass.NameDomainPropertyId, MakeIdent(cls.Name, true))) {
                DatabaseSchema = schema,
                TableName = name                
            };

            foreach (GenColumn p in cls.Columns.OrderBy(i => i.Index)) {
                ModelAttribute mpp = new ModelAttribute(store, new PropertyAssignment(ModelAttribute.NameDomainPropertyId, MakeIdent(p.Name, true))) {
                    ColumnName = p.Name,
                    ColumnType = p.DbType,
                    MaxLength = p.Length,
                    Type = p.Type,
                    Required = p.Required,
                    IsIdentity = p.IsPrimaryKey
                };
                mp.Attributes.Add(mpp);
            }

            modelRoot.Classes.Add(mp);
            return true;
        }

        public bool GenerateProc(GenProc proc)
        {
            ModelRoot modelRoot = store.ElementDirectory.AllElements.OfType<ModelRoot>().FirstOrDefault();

            ModelProcedure mp = new ModelProcedure(store, new PropertyAssignment(ModelProcedure.NameDomainPropertyId, MakeIdent(proc.Name, true))) {
                DatabaseSchema = schema,
                StoredProcName = name,
                ReturnType = proc.ReturnType,
                IsFunction = proc.IsFunction
            };

            foreach (GenParam p in proc.Params.OrderBy(i => i.Index)) {
                ModelParameter mpp = new ModelParameter(store, new PropertyAssignment(ModelParameter.NameDomainPropertyId, MakeIdent(p.Name, false))) {
                    ParameterName = p.Name,
                    ColumnType = p.DbType,
                    MaxLength = p.Length,
                    Type = p.Type,
                    Required = p.Required,
                    Direction = p.Direction.ToLower() == "in" ? ParamDirection.In : (p.Direction.ToLower() == "out" ? ParamDirection.Out : ParamDirection.InOut)
                };
                mp.Parameters.Add(mpp);
            }

            modelRoot.ModelProcedures.Add(mp);
            return true;
        }

        protected abstract GenClass GetTableInfo();
        protected abstract GenClass GetViewInfo();
        protected abstract GenProc GetProcInfo();
    }
}
