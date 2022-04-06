using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorA.Data
{
    class ConcreteMediator : IMediator
    {
        public string Title { get; set; }
        public Button Ok { get; set; }
        public CheckBox RememberMe { get; set; }

        public void Notify(AComponent sender, string Event)
        {
            if (sender.GetType().Name == "Button")
            {
                Console.WriteLine("buton clicklenmiş");
                Ok = (Button)sender;
                Ok.Execute();
            }

            if (sender.toString() == "CheckBox")
            {
                Console.WriteLine("checkbox işaretlenmiş");
                RememberMe = (CheckBox)sender;
                RememberMe.Execute();

            }
        }
    }
}
