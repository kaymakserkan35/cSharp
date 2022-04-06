using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeA.Bridge
{
    class AdvancedRemote : BasicRemote
    {
        public AdvancedRemote(ADevice device) : base(device)
        {
        }

        public void Mute()
        {
            Console.WriteLine("Volume = 0");
            device.setVolume(0);
        }

    }
}
