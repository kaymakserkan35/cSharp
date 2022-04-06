using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterB.Classses
{
    class SquarePegToRoundPegAdapter : RoundPeg
    {
        private SquarePeg peg;
        public SquarePegToRoundPegAdapter(SquarePeg peg)
        {
            this.peg = peg;
        }

        public  double Adapt()
        {
            double result;
            result = Math.Sqrt(Math.Pow((peg.width / 2), 2) * 2);
            return result;
        }
    }
}
