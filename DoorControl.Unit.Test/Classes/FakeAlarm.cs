using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControl.Unit.Test.Classes
{
    class FakeAlarm : DoorControllerH.Interfaces.IAlarm
    {
        public bool AlarmRaised { get; private set; }

        public FakeAlarm()
        {
            AlarmRaised = false;
        }
        public void RaiseAlarm()
        {
            AlarmRaised = true;
        }
    }
}
