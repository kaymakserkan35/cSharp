using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandB
{
    public class Application
    {

        public string clibboard { get; set; }
        public Editor editor { get; set; }
        public CommandHistory commandHistory { get; set; }
        public Application()
        {
            this.editor = new Editor();
            this.commandHistory = new CommandHistory();

        }
        public void CopyButtonUI()
        {
            var command = new CopyCommand(this, editor);
            command.Execute();
            commandHistory.AddHistory(command);
        }
        public void PasteButtonUI()
        {
            var command = new PasteCommand(this, editor);
            command.Execute();
            commandHistory.AddHistory(command);
        }
        public void UndoButtonUI()
        {
            var command = new UndoCommand(this, editor);
            command.Execute();
            commandHistory.AddHistory(command);

        }

    }
}
