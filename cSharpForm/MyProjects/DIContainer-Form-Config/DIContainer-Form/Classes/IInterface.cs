using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIContainer_Form
{
    public interface IInterface
    {
        public string methodFromInterface() { return "methodFromInterface"; }
        string GetConnectionString();
        void MethodToOverride();
    }
}
