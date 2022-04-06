using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorB.Data
{
    class Email : AEmail
    {
        private string AlıcıEmail;
        private string GondericiEmail;

        public Email(string alıcıEmail, string gondericiEmail)
        {
            AlıcıEmail = alıcıEmail;
            GondericiEmail = gondericiEmail;
        }

        public override AEmail EmailGonder(string mesaj)
        {
            Console.WriteLine($"{GondericiEmail} --> {mesaj} --> {AlıcıEmail}");
            return this;
        }
    }
}
