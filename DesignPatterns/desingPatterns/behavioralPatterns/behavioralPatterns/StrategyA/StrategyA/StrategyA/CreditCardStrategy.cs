using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyA.StrategyA
{
    class CreditCardStrategy : AStrategy
    {
        private static Dictionary<string, string> CreditCardDB = new Dictionary<string, string>();
        private bool isvalidCreadiCardDetails;
        private CreditCard card;

        public override void CollectPaymentDetails()
        {
            Console.WriteLine("Enter the card number: ");
            String number = Console.ReadLine();
            Console.WriteLine("Enter the card expiration date 'mm/yy': ");
            String date = Console.ReadLine();
            Console.WriteLine("Enter the CVV code: ");
            String cvv = Console.ReadLine();
            card = new CreditCard(number, date, cvv);
            ValidateCreditCard();
        }

        private bool ValidateCreditCard() { Console.WriteLine("credikartı bilgileri doğrulandı"); return isvalidCreadiCardDetails = true;  }

        public override bool Pay(int paymentAmount)
        {
            if(isvalidCreadiCardDetails)
            {
                Console.WriteLine($"paying {paymentAmount} using creditcard...");
                return true;
            }
            return false;
        }
    }
}
