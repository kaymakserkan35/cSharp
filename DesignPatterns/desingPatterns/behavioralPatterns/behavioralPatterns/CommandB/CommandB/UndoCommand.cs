using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandB
{
    public class UndoCommand : ACommand
    {
        public UndoCommand(Application application, Editor editor) : base(application, editor)
        {
        }

        public override void Execute(int startpoint, int endpoint)
        {
            throw new NotImplementedException();
        }
    }
}
