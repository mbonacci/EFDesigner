using Microsoft.VisualStudio.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawczyn.EFDesigner.EFModel
{
    public abstract partial class ProcedureShapeBase
    {
        private static string GetDisplayPropertyFromModelProcedureForParametersCompartment(ModelElement element)
        {
            ModelParameter param = element as ModelParameter;

            string nullable = param.Required ? "" : "?";
            string name = param.Name;
            string type = param.Type;

            return $"{name} : {type}{nullable}";
        }

        private bool GetVisibleValue()
        {
            return IsVisible;
        }

        private void SetVisibleValue(bool newValue)
        {
            if (newValue)
                Show();
            else
                Hide();
        }
    }
}
