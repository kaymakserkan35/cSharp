using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeA.Bridge
{
    interface IRemote
    {
        IRemote power();
        IRemote volumeDown();
        IRemote volumeUp();
        IRemote channelDown();
        IRemote channelUp();
    }
}
