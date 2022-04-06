using System;
using System.Collections.Generic;

namespace CommandC
{
    public class Account
    {
        public int Balance { get; set; }
        protected List<ATransactionCommands> TransactionCommands;

        public Account(int balance)
        {
            Balance = balance;
            TransactionCommands = new List<ATransactionCommands>();
            Console.WriteLine($"Hoşgeldiniz... Bakiyeniz {Balance}");
        }

        public void Deposit(int amount)
        {

            Balance += amount;
            Console.WriteLine($"yatırılan miktar {amount} -> yeni bakiye :  {Balance}");
        }

        public void WithDraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"çekilen miktar {amount} -> yeni bakiye :  {Balance}");
            }
            else
            {
                Console.WriteLine("bakiye yeterli değil!");
            }
        }


        public void AddTransactionCommand(ATransactionCommands txc)
        { TransactionCommands.Add(txc); }
        public List<ATransactionCommands> GetATransactionCommands()
        {
            return this.TransactionCommands;
        }

    }
}