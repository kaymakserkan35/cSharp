using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandB
{
    abstract public class ACommand
    {
        protected Application application { get; set; }
        protected Editor editor { get; set; }


        public ACommand(Application application, Editor editor)
        {
            this.application = application;
            this.editor = editor;
        }

        abstract public void Execute(int startpoint, int endpoint);
        abstract public void Execute();


    }
}
