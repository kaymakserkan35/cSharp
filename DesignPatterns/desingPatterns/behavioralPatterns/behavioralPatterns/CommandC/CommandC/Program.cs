using System;

namespace CommandC
{
    class Program
    {
        static void Main(string[] args)
        {
            Account accountA = new Account(200);
            ATransactionCommands depositcommand = new DepositCommand();
            depositcommand.setAccount(accountA);
            ATransactionCommands withdrawcommand = new WithDrawCommand();
            withdrawcommand.setAccount(accountA);

            depositcommand.execute(150);
            depositcommand.undo();
            depositcommand.redo();
            withdrawcommand.execute(15);
            withdrawcommand.undo();

            var TransactionHistory = accountA.GetATransactionCommands();
            foreach (var item in TransactionHistory)
            {
                Console.WriteLine(item.GetType().Name);
            }



        }
    }
}
