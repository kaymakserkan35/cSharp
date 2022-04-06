using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandB
{
   public class CommandHistory
    {
        private List<ACommand> commandsHistoryList;

        public void AddHistory(ACommand aCommand)
        {
            this.commandsHistoryList.Add(aCommand);
        }
        public void RemoveHistory(ACommand aCommand)
        {
            this.commandsHistoryList.Remove(aCommand);
        }
    }
}
