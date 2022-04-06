using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeA.Bridge
{
    class BasicRemote : IRemote
    {
        protected ADevice device;

        public BasicRemote(ADevice device)
        {
            this.device = device;
        }
        public IRemote power()
        {
            if (device.isEnabled)
            {
                Console.WriteLine($"{device.GetType().Name } , is shutdowned");
                device.isEnabled = false;
            }
            else
            {
                Console.WriteLine($"{device.GetType().Name} , is opened");
                device.isEnabled = true;
            }
            return this;
        }
        public IRemote channelDown()
        {
            device.setChannel(device.getChannel() - 1);
            Console.WriteLine($"{device.GetType().Name} -> Channel : {device.getChannel() - 1} ");
            return this;
        }

        public IRemote channelUp()
        {
            Console.WriteLine($"{device.GetType().Name} -> Channel : {device.getChannel() + 1} ");
            device.setChannel(device.getChannel() + 1);
            return this;
        }



        public IRemote volumeDown()
        {
            Console.WriteLine($"{device.GetType().Name} -> Volume : {device.getVolume() - 1} ");
            device.setVolume(device.getVolume() - 1);
            return this;
        }

        public IRemote volumeUp()
        {
            Console.WriteLine($"{device.GetType().Name} -> Volume : {device.getVolume() + 1} ");
            device.setVolume(device.getVolume() + 1);
            return this;
        }
    }
}
