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
            var _area = new Area();
            var _rooms = from r in _area.GetRooms()
                         select r;
            foreach(var room in _rooms)
            //Area.GetRooms();
            Console.WriteLine( $"Room {room.Id} has {room.numberOfBulbs} number of bulbs and {room.numberOfVents} number of vents." ); 
           
        }
    }
}
