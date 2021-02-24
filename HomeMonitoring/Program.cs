using System;
using System.Reflection;

//[assembly: AssemblyDescription("Home Monitoring App")]

namespace HomeMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {

            //Display the current condition : time of the day, outside temeperature - implement the weather API


            //Area.SetNumberOfRooms();

            Console.WriteLine("Hello! Please choose from next options: \n\r");
            Console.WriteLine("1 - Check the Status\n\r");
            Console.WriteLine("2 - Activate the system\n\r");
            Console.WriteLine("3 - Choose the room\n\r");
            
            Console.WriteLine("4 - Manage the devices\n\r");

            Console.WriteLine("Press q to quit!");

            string key = Console.ReadLine();

            if(key == "1")
            {
                Controller.GetStatus();
            }
            if (key == "2")
            {
                Area.GetRooms();
            }
            if (key == "4")
            {
                ManageMyDevices();
            }
            else if (key == "q")
            {
                Console.Clear();
            }
            
         


        }

        private static void ManageMyDevices()
        {
            Console.WriteLine("Press b1 to turn the bulb1 on or off");
            Console.WriteLine("Press b2 to turn the bulb1 on or off");
            Console.WriteLine("Press b3 to turn the bulb1 on or off");
            Console.WriteLine("Press b4 to turn the bulb1 on or off");
        }
    }
}
