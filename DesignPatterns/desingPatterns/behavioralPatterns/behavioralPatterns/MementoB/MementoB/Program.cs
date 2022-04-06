using System;
using System.Threading;

namespace MementoB
{
    class Program
    {
        static void Main(string[] args)
        {
            SettingsOriginator settings = new SettingsOriginator();
            CareTaker careTaker = new CareTaker(settings);

            for (int i = 1; i <= 20; i++)
            {
                Thread.Sleep(10);
                settings.UserId = i;
                settings.Email = i.ToString() + "@hotmail";
                settings.Password = Guid.NewGuid().ToString();
                if (i % 2 == 0) { settings.RememberMe = true; }
                else { settings.RememberMe = false; }

                careTaker.Backup();
                //careTaker.BackupAlternative();

            }

            careTaker.Undo();
            careTaker.Undo();
            careTaker.ShowBackupHistory();
            foreach (var memento in careTaker.mementos)
            {
                careTaker.GetOriginatorFromThatDate(memento.ChangedDate);
            }
        }
    }
}
