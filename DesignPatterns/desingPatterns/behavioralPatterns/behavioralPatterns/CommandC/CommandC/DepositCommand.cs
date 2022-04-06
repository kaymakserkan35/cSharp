using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandC
{
    class DepositCommand : ATransactionCommands
    {
        public override void execute(int amount)
        {
            this.amount = amount;
            account.Deposit(amount);
            account.AddTransactionCommand(this);
        }

        public override void undo()
        {
            account.WithDraw(amount);
            account.AddTransactionCommand(this);
            Console.WriteLine($"işlem geri alındı...");
        }
    }
}
