using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeA.Bridge
{
    class Tv : ADevice
    {

        private int Volume = 30;
        private int Channel = 1;

        public override bool isEnabled { get; set; }

        public override int getChannel()
        {
            return this.Channel;
        }

        public override int getVolume()
        {
            return this.Volume;
        }

        public override ADevice setChannel(int channel)
        {
            this.Channel = channel;
            return this;
        }

        public override ADevice setVolume(int percent)
        {
            this.Volume = percent;
            return this;
        }
    }
}
