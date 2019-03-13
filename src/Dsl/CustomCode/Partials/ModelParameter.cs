using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawczyn.EFDesigner.EFModel
{
    public partial class ModelParameter
    {
        public string PrimitiveType =>  ModelAttribute.ToPrimitiveType(Type);

        public string CLRName => MakeIdentifier(Name);

        private string MakeIdentifier(string name)
        {
            bool lower = true;
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
    }
}
