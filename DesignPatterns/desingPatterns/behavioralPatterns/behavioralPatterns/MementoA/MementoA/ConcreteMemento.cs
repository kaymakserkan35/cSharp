using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoA
{
    class ConcreteMemento : IMemento
    {
        private string State { get; set; }
        private DateTime Date { get; set; }

        public ConcreteMemento(string State)
        {
            this.State = State;
            this.Date = DateTime.Now;
        }



        public string GetName()
        {
            return $"{this.Date} / {this.State}";
        }

        public string GetState()
        {
            return this.State;
        }

        public DateTime GetDate()
        {
            return this.Date;
        }
    }
}
