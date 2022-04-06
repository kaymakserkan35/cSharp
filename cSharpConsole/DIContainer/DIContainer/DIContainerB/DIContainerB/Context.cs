using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIContainerB
{
    class Context
    {
        public IInterface @interface { get; set; }
        public Context(IInterface @interface)
        {
            this.@interface = @interface;
        }


        public void Do()
        {
            @interface.methodFromInterface();
            @interface.MethodToOverride();
        }
    }
}
