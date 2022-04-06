using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentA.Data
{
    class Leaf : AComponent
    {
      

        public override string Execute()
        {
            return "Leaf";
        }

      
        public override bool IsComposite()
        {
            return false;
        }
    }
}
