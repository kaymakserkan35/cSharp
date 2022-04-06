using ComponentA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentA.Data
{
    class Composite : AComponent
    {
        protected List<AComponent> components = new List<AComponent>();
        public override AComponent Add(AComponent component)
        {
             this.components.Add(component);
            return this;
        }
        public override AComponent Remove(AComponent component)
        {
            this.components.Remove(component);
            return this;
        }
        public override string Execute()
        {
            string result = "Branch (";   
            for (int i = 0; i <components.Count ; i++)
            {
                result += components[i].Execute();
                result += "<->";
            }
            result += ")";
            return result;
        }
    }
}
