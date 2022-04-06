using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeA.Bridge
{
    abstract class ADevice
    {
        abstract public bool isEnabled { get; set; }
        abstract public ADevice setVolume(int percent);
        abstract public ADevice setChannel(int channel);
        abstract public int getVolume();
        abstract public int getChannel();
        


    }
}
