using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodA
{
    class Facebook : ANetwork
    {
        public Facebook(string userName, string password) : base(userName, password)
        {
        }

        public override bool login(string username, string password)
        {
            Console.WriteLine("cheking user inputs..");
            return true;

        }

        public override void LogOut()
        {
            throw new NotImplementedException();
        }

        public override bool SendData(byte[] data)
        {
            throw new NotImplementedException();
        }
    }
}
