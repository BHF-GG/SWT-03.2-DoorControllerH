using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Unit.Test.Classes
{
    class FakeDoor : DoorControllerH.Interfaces.IDoor
    {
        private bool IsOpen = false;
        public int TimesOpened { get; private set; }
        public int TimesClosed { get; private set; }
        public void Open(DoorControllerH.Classes.DoorControl dc)
        {
            IsOpen = true;
            TimesOpened++;
            dc.DoorOpen();
        }

        public void Close(DoorControllerH.Classes.DoorControl dc)
        {
            IsOpen = false;
            TimesClosed++;
            dc.DoorClosed();
        }
    }
}
