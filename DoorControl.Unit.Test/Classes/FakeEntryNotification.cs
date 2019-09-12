using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Unit.Test.Classes
{
    class FakeEntryNotification : DoorControllerH.Interfaces.IEntryNotification
    {
        public bool _entryGranted { get; private set; }
        public int TimesGranted { get; private set; }
        public int TimesDenied { get; private set; }

        public FakeEntryNotification()
        {
            TimesDenied = 0;
            TimesGranted = 0;
            _entryGranted = false;
        }
        public void NotifyEntryDenied()
        {
            _entryGranted = false;
            TimesDenied++;
            
        }

        public void NotifyEntryGranted()
        {
            _entryGranted = true;
            TimesGranted++;
        }
    }
}
