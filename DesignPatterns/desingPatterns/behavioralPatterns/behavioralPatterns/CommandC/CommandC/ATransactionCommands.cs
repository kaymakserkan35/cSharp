using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandC
{
    abstract public class ATransactionCommands
    {
        protected Account account;
        protected int amount;

        abstract public void execute(int amount);
        abstract public void undo();
        virtual public void redo() { execute(amount); }
        virtual public List<ATransactionCommands> GetTransactions()
        {
            return this.account.GetATransactionCommands();
        }
        virtual public void setAccount(Account account)
        { this.account = account; }
    }


}
