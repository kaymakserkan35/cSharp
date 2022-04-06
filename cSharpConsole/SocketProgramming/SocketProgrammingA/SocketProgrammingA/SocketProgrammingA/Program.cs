using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketProgrammingA
{
   public class Program
    {
        public static void Main(String[] args)
        {

            Task taskA = new Task(() => {
                SocketListener socketListener = new SocketListener();
                socketListener.StartServer();
            });
            taskA.Start();
            if (taskA.IsCompletedSuccessfully)
            {
                Console.WriteLine("socket listener completed");
            }
          

            Task taskB = new Task( ()=> {
                SocketClient socketClient = new SocketClient();
                socketClient.StartClient();
            } );
            taskB.Start();
            if (taskA.IsCompletedSuccessfully)
            {
                Console.WriteLine("SocketClient completed");
            }






        }
    }
}
