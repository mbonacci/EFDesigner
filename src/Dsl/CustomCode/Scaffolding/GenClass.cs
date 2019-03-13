using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawczyn.EFDesigner.EFModel.ModelGen
{
    public class GenClass
    {
        public string Name { get; set; }
        public string Schema { get; set; }
        public List<GenColumn> Columns { get; set; } = new List<GenColumn>();
    }
}
