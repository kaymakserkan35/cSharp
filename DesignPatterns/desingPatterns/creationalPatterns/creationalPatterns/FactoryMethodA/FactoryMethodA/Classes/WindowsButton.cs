using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodA.Classes
{
    public class WindowsButton : AbstractButton
    {
        public override void OnClick()
        {
            Console.WriteLine("windows button on clicked!");
        }

        public override void Render()
        {
            Console.WriteLine("windows button rendered!");
        }
    }
}
