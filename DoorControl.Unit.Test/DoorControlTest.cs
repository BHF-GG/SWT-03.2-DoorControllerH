using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControl.Unit.Test.Classes;
using NUnit.Framework;

namespace DoorControl.Unit.Test
{
    [TestFixture]
    public class DoorControlTest
    {
        private DoorControllerH.Classes.DoorControl uut;
        private FakeAlarm fAlarm;
        private FakeDoor fDoor;
        private FakeEntryNotification fEntryNotification;
        private FakeUserValidation fUserValidation;

        [SetUp]
        public void SetUp()
        {
            fAlarm = new FakeAlarm();
            fDoor = new FakeDoor();
            fEntryNotification = new FakeEntryNotification();
            fUserValidation = new FakeUserValidation();
            uut = new DoorControllerH.Classes.DoorControl(fDoor, fEntryNotification, fAlarm, fUserValidation);
        }

        [TestCase(1, true,1,0)]
        [TestCase(2, false,0,1)]
        public void RequestEntry_ValidatesCorrectID(int id, bool entryGrantedStatus, int timesGranted, int timesDenied)
        {
            uut.RequestEntry(id);
            Assert.That(fEntryNotification._entryGranted, Is.EqualTo(entryGrantedStatus));
            Assert.That(fEntryNotification.TimesGranted, Is.EqualTo(timesGranted));
            Assert.That(fEntryNotification.TimesDenied,Is.EqualTo(timesDenied));
        }

        [TestCase(1, 1, 1)]
        [TestCase(2, 0, 0)]
        public void DoorOpen_CheckTimesOpened(int id, int timesOpened, int timesClosed)
        {
            uut.RequestEntry(id);
            Assert.That(fDoor.TimesOpened,Is.EqualTo(timesOpened));
            Assert.That(fDoor.TimesClosed,Is.EqualTo(timesClosed));
        }
    }
}
