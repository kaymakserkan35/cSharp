using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseB.ChainResponseB
{

    public class AHandler : IHandler
    {
        private IHandler nextHandler;

 
        public AHandler SetNext(IHandler handler)
        {
            this.nextHandler = handler;
            return this;
        }

        public virtual object Handle(object request)
        {
            if (this.nextHandler != null) { return this.nextHandler.Handle(request); }
            return null;
        }

        public IHandler Next(IHandler handler)
        {
            throw new NotImplementedException();
        }
    }
}
