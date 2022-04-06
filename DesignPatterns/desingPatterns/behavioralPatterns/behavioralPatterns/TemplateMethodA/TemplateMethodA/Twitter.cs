using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodA
{
    class Twitter : ANetwork
    {
        public Twitter(string userName, string password) : base(userName, password)
        {
        }

        public override bool login(string username, string password)
        {
            throw new NotImplementedException();
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
