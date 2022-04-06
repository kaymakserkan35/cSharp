using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIContainer_Form.Classes
{
    public abstract class ATemplate
    {

        public abstract string TemplateMethod();
        public abstract string GetConnectionString();
    }
    public class Template : ATemplate
    {
        private IInterface concreate { get; set; }

        public Template(IInterface concreate)
        {
            this.concreate = concreate;
        }

        public override string TemplateMethod()
        {
            return concreate.methodFromInterface();

        }

        public override string GetConnectionString()
        {
            return concreate.GetConnectionString();
        }


    }
}
