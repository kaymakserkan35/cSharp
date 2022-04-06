using System;
using System.Media;
using WMPLib;

namespace keyPressedEvent
{

    class Program 
    {
        
        static void Main(string[] args)
        {
            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                consoleKeyInfo = Console.ReadKey();
                onPressed(consoleKeyInfo);
                playSound("sound");

            } while (consoleKeyInfo.Key != ConsoleKey.Escape);


        }

        private static void playSound(string soundName)
        {
            
            WindowsMediaPlayer myplayer = new WindowsMediaPlayer();
            WMPPlayState playState = myplayer.playState;
            if (playState == WMPPlayState.wmppsPlaying) { return; }
            myplayer.URL = soundName+".mp3";
            myplayer.controls.play();
           
            
            
        }
        public static void onPressed(ConsoleKeyInfo consoleKeyInfo)
        {
            Console.Write(" --- You pressed ");
            Console.WriteLine(consoleKeyInfo.Key.ToString());
        }
    }
}
