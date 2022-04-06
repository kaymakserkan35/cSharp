using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyA.StrategyA
{
    abstract public class AStrategy
    {

        abstract public bool Pay(int paymentAmount);
        abstract public void CollectPaymentDetails();
    }
}
