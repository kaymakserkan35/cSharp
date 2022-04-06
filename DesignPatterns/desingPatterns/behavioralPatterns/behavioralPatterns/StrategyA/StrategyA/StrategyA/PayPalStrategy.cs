using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyA.StrategyA
{
    class PayPalStrategy : AStrategy
    {
        private static Dictionary<string, string> database = new Dictionary<string, string>()
        { { "serkan@hotmail" ,"123" } , { "onur@hotmail" ,"123" }   };
        private string email;
        private string password;
        private bool signedIn;


        public override void CollectPaymentDetails()
        {
            while (!signedIn)
            {
                Console.WriteLine("enter user email");
                email = Console.ReadLine();
                Console.WriteLine("enter password");
                password = Console.ReadLine();
                if (Verify())
                {
                    signedIn = true;  
                }
               
            }
        }


        public bool Verify()
        {
            var user = database.FirstOrDefault(x=>x.Key==email && x.Value==password);
            Console.WriteLine("login success!!");
            return true;
        }

        public override bool Pay(int paymentAmount)
        {
            if (signedIn)
            {
                Console.WriteLine($"paying {paymentAmount} using PayPal... ");
                return true;
            }
            return false;
        }
    }
}
