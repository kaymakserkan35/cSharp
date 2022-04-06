using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyB
{
    class Context
    {
        private AStrategy strategy;

        public Context(AStrategy strategy)
        {
            this.strategy = strategy;
        }


        public void SetStrategy(AStrategy strategy)
        {
            this.strategy = strategy;
        }


        public void DoSomeBusinessLogic()
        {

            var result = this.strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });
            WriteList(result as List<string>);

        }

        public void WriteList(List<string> list)
        {
            foreach (var element in list)
            {
                Console.Write($"{  element.ToString()}" + ",");
            }
        }
    }
}
