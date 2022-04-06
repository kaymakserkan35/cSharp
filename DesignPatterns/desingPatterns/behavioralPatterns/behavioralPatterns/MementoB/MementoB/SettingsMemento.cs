using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoB
{
    class SettingsMemento
    {

        public DateTime ChangedDate { get; set; } // setting sınıfının değiştirilme tarihi ...
        public SettingsOriginator obj { get; set; }

        public SettingsMemento(SettingsOriginator obj)
        {
            //  this.obj = obj; referans tipte dir caretaker içindeki mementos içerikleri hep enson bilgiyi tutar sadece sayı artar!
            this.obj = new SettingsOriginator();
            this.obj.UserId = obj.UserId;
            this.obj.Password = obj.Password;
            this.obj.Email = obj.Email;
            this.obj.RememberMe = obj.RememberMe;
            ChangedDate = DateTime.Now;
        }

        public void SettingsOriginator(SettingsOriginator settingsOriginator)
        {
            this.obj = settingsOriginator;
        }

    }
}
