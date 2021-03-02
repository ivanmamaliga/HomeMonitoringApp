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
            CurrentCondition.GetCurrentTime();

            Console.WriteLine(CurrentCondition.GetWeather()); 

            //Area.SetNumberOfRooms();

            displayMainMenu();

            string key = Console.ReadLine();

            switch(key)
            {
                case "1":
                    Controller.GetStatus();
                    break;

                case "2":
                    Area.GetRooms();
                    break;

                case "3":
                    ManageMyDevices();
                    break;

                case "q":
                    break;

                case "r":
                    displayMainMenu();
                    break;

            }
            

            Area.SetNumberOfRooms();
         


        }

        public static void displayMainMenu()
        {

            Console.WriteLine("Please choose from next options: \n\r");
            Console.WriteLine("1 - Check the Status\n\r");
            //Console.WriteLine("2 - Activate the system\n\r");
            Console.WriteLine("2 - Choose the room\n\r");

            Console.WriteLine("3 - Manage the devices\n\r");

            Console.WriteLine("Press q to quit!");

            Console.WriteLine("Press r to return to main menu!");

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
