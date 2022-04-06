using System;

namespace EventInCsharp
{
    public class Metronome
    {
        public event TickHandler Tick;
        public EventArgs e = null;
        public delegate void TickHandler(Metronome m, EventArgs e);
        public void Start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(3000);
                if (Tick != null)
                {
                    Tick(this, e);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Metronome m = new Metronome();
            m.Tick += (Metronome m , EventArgs e) => {
                System.Console.WriteLine("HEARD IT");
            };
            m.Start();
        }
    }
}
