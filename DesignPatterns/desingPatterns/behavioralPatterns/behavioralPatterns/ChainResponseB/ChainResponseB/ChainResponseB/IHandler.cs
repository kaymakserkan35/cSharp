using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponseB.ChainResponseB
{
   public interface IHandler
    {
        IHandler Next(IHandler handler);
        object Handle(object request);
    }
}
