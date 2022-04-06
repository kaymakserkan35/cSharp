using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoB
{
    class SettingsOriginator
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool RememberMe { get; set; }

        public SettingsMemento Save()
        {
            return new SettingsMemento(this);
        }
        public SettingsMemento SaveAlternative()
        {
            return new SettingsMemento((SettingsOriginator)this.MemberwiseClone());
        }

        public void Restore(SettingsMemento memento)
        {
            this.UserId = memento.obj.UserId;
            this.Password = memento.obj.Password;
            this.Email = memento.obj.Email;
            this.RememberMe = memento.obj.RememberMe;

            Console.WriteLine($"obje restore edildi");
            Console.WriteLine($" userID : {this.UserId}- Password : {this.Password}- Email : {this.Email}- RememberME : {this.RememberMe}");
        }


    }
}
