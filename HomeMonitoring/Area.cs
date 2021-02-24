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

        public static void SetNumberOfRooms()
        {
            Console.WriteLine("Please choose the number of Rooms : \r\n");

            Console.WriteLine("1 - one room \r\n");
            Console.WriteLine("2 - two rooms \r\n");

        }

       
        public static List<Room> GetRooms()
        {
            Room room1 = new Room(); // add a constructor to initialise to number of bulbs and vents

            Room room2 = new Room();

            List<Room> rooms = new List<Room>() { room1, room2 };

            return rooms;
        }
        







    }
}
