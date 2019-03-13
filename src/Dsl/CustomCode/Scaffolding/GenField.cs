using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawczyn.EFDesigner.EFModel.ModelGen
{
    public abstract class GenField
    {
        public string Name { get; set; }
        public int Index { get; set; }
        public string DbType { get; set; }
        public int Length { get; set; }
        public int Precision { get; set; }
        public int Scale { get; set; }
        public string Type { get; set; }
        public bool Required { get; set; }
    }

    public class GenColumn : GenField
    {
        public bool IsPrimaryKey { get; set; }
        public int PrimaryKeyIndex { get; set; }
    }

    public class GenParam : GenField
    {
        public string Direction { get; set; }
    }

}
