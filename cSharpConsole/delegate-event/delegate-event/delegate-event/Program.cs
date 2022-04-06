using System;

namespace delegate_event
{
    public delegate void delegateNotify( Object sender, int speed);


    public class Car
    {
        public event delegateNotify eventHandler;
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 80 && eventHandler != null)
                {
                    
                    eventHandler(this,value);
                }
                else
                {
                    speed = value;
                }
            }

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Car myobj = new Car();
            myobj.eventHandler += (sender , speed) =>
            {
                speed = 82;
                Console.WriteLine($"hız limiti aşıldı.Hız : {speed}'de sabitleniyor");
            };


            for (int i = 60; i < 100; i += 5)
            {
                myobj.Speed = i;
                Console.WriteLine($"araba hızlanıyor: {myobj.Speed} km/sa");

            }
        }
    }


}