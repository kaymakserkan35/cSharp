using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeA.Bridge
{
    class Radio : ADevice
    {

        private int Volume { get; set; }
        private int Channel { get; set; }


        public override bool isEnabled { get; set; }


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

        public override int getVolume()
        {
            return this.Volume;
        }

        public override int getChannel()
        {
            return this.Channel;
        }
    }
}
