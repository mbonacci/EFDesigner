using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawczyn.EFDesigner.EFModel.ModelGen
{
    public class GenProc
    {
        public string PackageName { get; set; }
        public string Name { get; set; }
        public string Schema { get; set; }
        public bool IsFunction { get; set; }
        public string ReturnDbType { get; set; }
        public string ReturnType { get; set; }
        public List<GenParam> Params { get; set; } = new List<GenParam>();
    }
}
