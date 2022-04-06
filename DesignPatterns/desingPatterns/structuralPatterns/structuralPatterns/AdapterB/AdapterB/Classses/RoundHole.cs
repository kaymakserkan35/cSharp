using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterB.Classses
{
    class RoundHole
    {
        public double radius;
       
        public RoundHole(double radius)
        { this.radius = radius; }
        public bool IsFits(RoundPeg peg)
        {
            return (this.radius >= peg.radius) ? true : false;
        }
    }
}
