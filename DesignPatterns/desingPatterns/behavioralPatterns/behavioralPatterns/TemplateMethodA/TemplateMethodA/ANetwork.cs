using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodA
{
    abstract class ANetwork
    {
        string UserName;
        string Password;

        protected ANetwork(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public bool Post(string Message)
        {
            if (login(this.UserName, this.Password))
            {
                bool messagebytes = SendData(Encoding.ASCII.GetBytes(Message));
                LogOut();
                return messagebytes;

            }
            return false;
        }

        abstract public bool login(string username, string password);
        abstract public bool SendData(byte[] data);
        abstract public void LogOut();
    }
}
