using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorB.Data
{
    class MesajSifreleEmailDecorator : EmailDecorator
    {
        public MesajSifreleEmailDecorator(AEmail email) : base(email)
        {
        }


        public override AEmail EmailGonder(string mesaj)
        {
            mesaj = mesaj.GetHashCode().ToString();
            return base.EmailGonder(mesaj);

        }
    }
}
