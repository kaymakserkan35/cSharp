using System;

namespace thiskeyword
{

    class ToyCar
    {
        public string nameToy;
        public int speed;
        public int deneme;

        public ToyCar() { }
        public ToyCar(int s) : this("", s) { }
        public ToyCar(string n) : this(n, 0) { }
        public ToyCar(string n, int s)
        {
            if (s < 10)
                speed = 10;
            speed = s;
            nameToy = n;
        }

        public void SetName(string name)
        {
            this.nameToy = name;
        }

        public void PrintState()
        {
            Console.WriteLine("{0}'s speed is {1} mph.", nameToy, speed);
        }

      
    }




    class Program
    {
        static void Main(string[] args)
        { 
            ToyCar myToy = new ToyCar(100);
            myToy.SetName("Boom Boom Boom");
            myToy.PrintState();

            Console.WriteLine();
        }
    }
}

