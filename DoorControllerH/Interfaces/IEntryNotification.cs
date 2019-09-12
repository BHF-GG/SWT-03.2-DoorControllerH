using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorControllerH.Interfaces
{
    public interface IEntryNotification
    {
        void NotifyEntryDenied();
        void NotifyEntryGranted();

    }
}
