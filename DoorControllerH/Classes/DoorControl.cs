using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControllerH.Interfaces;

namespace DoorControllerH.Classes
{
    public class DoorControl
    {
        private IDoor _door;
        private IEntryNotification _entryNotification;
        private IAlarm _alarm;
        private IUserValidation _userValidation;
        private bool _doorOpenOK;

        public DoorControl(IDoor door, IEntryNotification entryNotification, IAlarm alarm, IUserValidation userValidation)
        {
            _door = door;
            _entryNotification = entryNotification;
            _alarm = alarm;
            _userValidation = userValidation;
            _doorOpenOK = false;

        }

        public void RequestEntry(int id)
        {
            if (_userValidation.ValidateEntryRequest(id))
            {
                _doorOpenOK = true;
                _door.Open(this);
                _entryNotification.NotifyEntryGranted();
            }
            else
            {
                _entryNotification.NotifyEntryDenied();
            }
        }

        public void DoorOpen()
        {
            _door.Close(this);
            if (!_doorOpenOK)
                _alarm.RaiseAlarm();
        }

        public void DoorClosed()
        {
            _doorOpenOK = false;
        }

    }
}
