using StrategyA.StrategyA;
using System;

namespace StrategyA
{
    class Program
    {
        private static Order order = new Order();
        private static AStrategy strategy;

        static void Main(string[] args)
        {
            if (strategy==null)
            {
                Console.WriteLine("Please, select a payment method:" + "\n" +
                        "1 - PalPay" + "\n" +
                        "2 - Credit Card");
                string paymentmethod = Console.ReadLine();
                if (paymentmethod=="1")
                {
                    strategy = new PayPalStrategy();
                }
                if (paymentmethod=="2")
                {
                    strategy = new CreditCardStrategy();
                }


                order.processOrder(strategy);
                strategy.Pay(250);
            }
            
        }
    }
}
