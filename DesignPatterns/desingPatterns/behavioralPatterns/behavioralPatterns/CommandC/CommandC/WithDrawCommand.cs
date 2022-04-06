using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandC
{
    class WithDrawCommand : ATransactionCommands
    {
        public override void execute(int amount)
        {
            this.amount = amount;
            account.WithDraw(amount);
            account.AddTransactionCommand(this);
        }

        public override void undo()
        {
            account.Deposit(amount);
            account.AddTransactionCommand(this);
            Console.WriteLine("işlem geri alındı...");
        }
    }
}
