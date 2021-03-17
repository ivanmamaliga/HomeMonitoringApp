using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMonitoring
{
    class Devices
    {
        public static void ManageDevices()
        {
            Area.GetRooms();
            Console.WriteLine("Press b1 to turn the bulb1 on or off");
            Console.WriteLine("Press b2 to turn the bulb1 on or off");
            Console.WriteLine("Press b3 to turn the bulb1 on or off");
            Console.WriteLine("Press b4 to turn the bulb1 on or off");
        }
    }
}
