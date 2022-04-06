using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodA.Classes
{
    abstract public class AbstractFactory
    {
        abstract public AbstractButton CreateButton();
        void Render()
        {
            AbstractButton button = CreateButton();
            button.Render();
        }

    }
}
