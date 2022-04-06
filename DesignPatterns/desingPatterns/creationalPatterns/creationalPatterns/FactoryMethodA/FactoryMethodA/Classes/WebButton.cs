using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodA.Classes
{
    public class WebButton : AbstractButton
    {
        public override void OnClick()
        {
            Console.WriteLine("Web button oc clicked!");
        }

        public override void Render()
        {
            Console.WriteLine("Web button rendered!");
        }
    }
}
