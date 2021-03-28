using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMonitoring
{
    /// <summary>
    /// Area(House) setup?
    /// </summary>
    class Area 
    {
        public int numberOfRooms { get; set; } = 1;

        public List<Room> rooms = new List<Room>()
        {
            new Room(){ Id = "room1", numberOfBulbs = 2, numberOfVents = 4},
            new Room(){ Id = "room2", numberOfBulbs = 3, numberOfVents = 4}
        };
        public List<Room> GetRooms() => rooms;

                   
    }
}
