using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoorControllerH.Classes;

namespace DoorControllerH.Interfaces
{
    public interface IDoor
    {
        void Open(DoorControl dc);
        void Close(DoorControl dc);
    }
}
