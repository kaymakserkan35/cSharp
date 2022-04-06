using AdapterB.Classses;
using System;

namespace AdapterB
{
    class Program
    {
        static void Main(string[] args)
        {
            // Round fits round, no surprise.
            RoundHole hole = new RoundHole(5);
            RoundPeg rpeg = new RoundPeg(5);
            if (hole.IsFits(rpeg))
            {
                Console.WriteLine("Round peg r5 fits round hole r5.");
            }

            SquarePeg smallSqPeg = new SquarePeg(2);
            SquarePeg largeSqPeg = new SquarePeg(20);
            // hole.IsFits(smallSqPeg); // Won't compile.
            /*---------------------------------------------*/
            // Adapter solves the problem.
            SquarePegToRoundPegAdapter smallSqPegAdapter = new SquarePegToRoundPegAdapter(smallSqPeg);
            SquarePegToRoundPegAdapter largeSqPegAdapter = new SquarePegToRoundPegAdapter(largeSqPeg);
            if (hole.IsFits(smallSqPegAdapter))
            {
                Console.WriteLine("Square peg fits...");

            }
            if (!hole.IsFits(largeSqPegAdapter))
            {
                Console.WriteLine("Square peg  does not fits...");
            }
        }
    }
}
