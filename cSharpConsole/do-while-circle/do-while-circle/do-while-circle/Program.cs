using System;
using System.Collections.Generic;

namespace do_while_circle
{
    class Program
    {
        double x { get; set; }
        double y { get; set; }
        Dictionary<double, double> coordinats = new();
        Random rand = new Random();

        static void Main(string[] args)
        {
            var obj = new Program();
            obj.circleDraw();



        }

        void circleDraw()
        {
            do
            {
                x = rand.NextDouble();
                y = rand.NextDouble();


                coordinats.Add(x, y);

            } while (Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2)) > 1);


            foreach (var coordinat in coordinats)
            {
                Console.WriteLine(x.ToString(), y.ToString());
            }
        }
    }
}
