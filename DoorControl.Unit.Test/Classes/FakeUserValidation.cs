using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControllerH.Interfaces;

namespace DoorControl.Unit.Test.Classes
{
    class FakeUserValidation : DoorControllerH.Interfaces.IUserValidation
    {
       public bool ValidateEntryRequest(int id)
       {
           if (id == 1)
               return true;
           else
               return false;
       }
    }
}
