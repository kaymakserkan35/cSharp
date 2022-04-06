using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterB.Classses
{
    class RoundPeg 
    {

        public double radius { get; set; }
        public RoundPeg()
        {

        }
        public RoundPeg(double radius)
        {
            this.radius = radius;
        }
    }
}
