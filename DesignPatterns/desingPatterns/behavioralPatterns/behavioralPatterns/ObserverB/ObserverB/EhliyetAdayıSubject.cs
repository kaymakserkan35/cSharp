using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverB
{
    class EhliyetAdayıSubject : ISubject
    {
        public class Car
        { public double Hız { get; set; } = 30; }
        public int HataPuanı { get; set; } = 0;
        List<IObserver> observers;
        public Car car;
        public EhliyetAdayıSubject()
        {
            car = new Car();
            observers = new List<IObserver>();
        }

        public void Hızlan() { car.Hız += 10; Console.WriteLine($"Aracın hızı : {car.Hız}"); this.Notify(); }
        public void Yavaşla() { car.Hız -= 10; Console.WriteLine($"Aracın hızı : {car.Hız}"); this.Notify(); }
        public void KırmızıIsıktaGec() { this.HataPuanı += 25; Console.WriteLine($"Hata Puanın {HataPuanı}"); this.Notify(); }
        public void YanlışPartEt() { this.HataPuanı += 25; Console.WriteLine($"Hata Puanın {HataPuanı}"); this.Notify(); }
        public void AracıÇarp() { this.HataPuanı += 100; Console.WriteLine($"Hata Puanın {HataPuanı}"); this.Notify(); }

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }
    }
}
