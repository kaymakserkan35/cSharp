using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorB.Data
{
    class DosyaEkleEmailDecorator : EmailDecorator
    {
        private string dosya;
        public DosyaEkleEmailDecorator(AEmail email, string dosya) : base(email)
        {
            this.dosya = dosya;
        }

        public override AEmail EmailGonder(string mesaj)
        {
            mesaj += $" I Dosyanız ektedir : {dosya} ";
            return base.EmailGonder(mesaj);
        }
    }
}
