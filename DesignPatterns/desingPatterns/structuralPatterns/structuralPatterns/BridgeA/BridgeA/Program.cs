using BridgeA.Bridge;
using System;

namespace BridgeA
{
    class Program
    {
        static void Main(string[] args)
        {
            testDevice(new Tv());
            testDevice(new Radio());
        }


        public static void testDevice(ADevice device)
        {
            // Console.WriteLine("Tests with basic remote.");
            BasicRemote basicRemote = new BasicRemote(device);
            basicRemote.power();
            basicRemote.channelUp();
            basicRemote.volumeDown();


            //  Console.WriteLine("Tests with advanced remote.");
            AdvancedRemote advancedRemote = new AdvancedRemote(device);
            advancedRemote.power();
            advancedRemote.Mute();

        }
    }
}
