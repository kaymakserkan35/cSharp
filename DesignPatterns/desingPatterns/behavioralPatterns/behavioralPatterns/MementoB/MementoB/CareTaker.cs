using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoB
{
    class CareTaker
    {
        public List<SettingsMemento> mementos { get; set; }
        public SettingsOriginator originator { get; set; }

        public CareTaker(SettingsOriginator settingsOriginator)
        {
            this.originator = settingsOriginator;
            mementos = new List<SettingsMemento>();
        }

        public void Backup()
        {
            this.mementos.Add(this.originator.Save());

        }
        public void BackupAlternative()
        {
            this.mementos.Add(this.originator.SaveAlternative());
        }
        public void Undo()
        {
            if (this.mementos.Count == 0) return;
            var memento = this.mementos.Last();
            this.originator.Restore(memento);
            this.mementos.Remove(memento);
        }

        public void ShowBackupHistory()
        {
            foreach (var memento in mementos)
            {
                Console.WriteLine($" changedDate :  {memento.ChangedDate}  CHANGES---->   UserId :  {memento.obj.UserId} Pasword: {memento.obj.Password}");
            }
        }

        public void GetOriginatorFromThatDate(DateTime dateTime)
        {
            foreach (var memento in mementos)
            {
                if (memento.ChangedDate == dateTime)
                {
                    this.originator.Restore(memento);
                }
            }
        }


    }
}
