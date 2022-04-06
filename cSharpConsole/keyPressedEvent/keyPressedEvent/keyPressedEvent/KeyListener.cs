using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyPressedEvent
{
    public interface KeyListener
    {
        public void onPressed(ConsoleKeyInfo consoleKeyInfo);
    }
}
