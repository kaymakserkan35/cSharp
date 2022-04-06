using System;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DIContainer_Form
{
    class Concrete : IInterface
    {
        private string _connectionstring = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        public void MethodToOverride()
        {

        }
        public string GetConnectionString()
        {
            return (this._connectionstring);
        }


    }
}
