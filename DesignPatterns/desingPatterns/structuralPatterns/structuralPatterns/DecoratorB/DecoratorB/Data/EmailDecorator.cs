using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorB.Data
{
    class EmailDecorator : AEmail
    {
        private AEmail email;

        public EmailDecorator(AEmail email)
        {
            this.email = email;
        }

        public override AEmail EmailGonder(string mesaj)
        {
            email.EmailGonder(mesaj);
            return this;
        }
    }
}
