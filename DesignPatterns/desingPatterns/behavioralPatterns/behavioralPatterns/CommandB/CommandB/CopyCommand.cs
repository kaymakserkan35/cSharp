using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandB
{
    public class CopyCommand : ACommand
    {
        public CopyCommand(Application application, Editor editor) : base(application, editor)
        {

        }

        public override void Execute(int startP, int endP)
        {
            application.clibboard = editor.GetSelection(startP, endP);
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
