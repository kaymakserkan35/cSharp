using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyA.StrategyA
{

    public class Order
    {
        private int totalCost = 0;
        private bool isClosed = false;

        public void processOrder(AStrategy strategy)
        {
            strategy.CollectPaymentDetails();
        }

        public void setTotalCost(int cost)
        {
            this.totalCost += cost;
        }

        public int getTotalCost()
        {
            return totalCost;
        }

        public bool IsClosed()
        {
            return isClosed;
        }

        public void setClosed()
        {
            isClosed = true;
        }
    }

}
