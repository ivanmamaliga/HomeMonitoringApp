﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMonitoring
{
    class DevicesManagement
    {
        public static void ManageDevices()
        {
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            var _area = new Area();

            var _rooms = from r in _area.GetRooms()
                         select r;
            foreach (var room in _rooms)
            { Console.WriteLine($"Room {room.Id} has {room.numberOfBulbs} bulbs and {room.numberOfVents} vents."); }
                         
        }

        public static void TurnBulbsOn()
        {
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The lights are ON!");

        }
        public static void TurnBulbsOFF()
        {
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The lights are OFF!");
        }
    }
}
