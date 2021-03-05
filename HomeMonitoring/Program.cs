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

            var exit = false;
            CurrentCondition.GetCurrentTime();

            CurrentCondition.GetCurrentConditions();

            //Area.SetNumberOfRooms();

            while (!exit)
            {
                switch (ProvideMenuOptions())
                {
                    case MenuOption.CheckTheStatus:
                        //string results = await GetCurrentTemperature();
                        //if (results != default)
                        //    Console.WriteLine($"The current temperature is {results}");
                        //else
                        //    PrintErrorMessage("Unable to retrieve weather data...");
                        Console.WriteLine("Press any key continue...");
                        Console.ReadKey();
                        break;
                    case MenuOption.ChooseRoom:
                        //string convertResults = ConvertTemperature();
                        //if (convertResults != _unableToConvertTemperature)
                        //    Console.WriteLine($"Converted temperature is {convertResults}");
                        //else
                        //    PrintErrorMessage(convertResults);
                        Console.WriteLine("Press any key continue...");
                        Console.ReadKey();
                        break;
                    case MenuOption.ManageDevices:
                        //string convertResults = ConvertTemperature();
                        //if (convertResults != _unableToConvertTemperature)
                        //    Console.WriteLine($"Converted temperature is {convertResults}");
                        //else
                        //    PrintErrorMessage(convertResults);
                        Console.WriteLine("Press any key continue...");
                        Console.ReadKey();
                        break;
                    case MenuOption.Exit:
                        exit = true;
                        break;
                }
            }
           



            Area.SetNumberOfRooms();
         


        }

        //public static void displayMainMenu()
        //{

        //    Console.WriteLine("Please choose from next options: \n\r");
        //    Console.WriteLine("1 - Check the Status\n\r");
        //    //Console.WriteLine("2 - Activate the system\n\r");
        //    Console.WriteLine("2 - Choose the room\n\r");

        //    Console.WriteLine("3 - Manage the devices\n\r");

        //    Console.WriteLine("Press q to quit!");

        //    Console.WriteLine("Press r to return to main menu!");

        //}
        private static MenuOption ProvideMenuOptions()
        {

            //ConsoleColor foregroundColor = Console.ForegroundColor;

            //int returnValue = -1 ;

            ////int minDemoOptionValue = (int)Enum.GetValues(typeof(MenuOption)).Cast<MenuOption>().First();
            ////int maxDemoOptionValue = (int)Enum.GetValues(typeof(MenuOption)).Cast<MenuOption>().Last();
            //while (returnValue > -1 )
            //{
            //Console.Clear();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"  _   _                        __  __             _ _             _             ");
            Console.WriteLine(@" | | | | ___  _ __ ___   ___  |  \/  | ___  _ __ (_) |_ ___  _ __(_)_ __   __ _ ");
            Console.WriteLine(@" | |_| |/ _ \| '_ ` _ \ / _ \ | |\/| |/ _ \| '_ \| | __/ _ \| '__| | '_ \ / _` |");
            Console.WriteLine(@" |  _  | (_) | | | | | |  __/ | |  | | (_) | | | | | || (_) | |  | | | | | (_| |");
            Console.WriteLine(@" |_| |_|\___/|_| |_| |_|\___| |_|  |_|\___/|_| |_|_|\__\___/|_|  |_|_| |_|\__, |");
            Console.WriteLine(@"                                                                          |___/ "); Console.WriteLine("");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Choose the demo to run:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t [1]  CheckTheStatus");
            Console.WriteLine("\t [2]  ChooseRoom");
            Console.WriteLine("\t [3]  ManageDevices");
            Console.WriteLine("\t[ESC] Exit demo");
            //Console.ForegroundColor = foregroundColor;
            var keyPress = Console.ReadKey(true);
            var returnValue = 0;
            switch (keyPress.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    returnValue = (int)MenuOption.CheckTheStatus;
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    returnValue = (int)MenuOption.ChooseRoom;
                    break;
                case ConsoleKey.NumPad3:
                    returnValue = (int)MenuOption.ManageDevices;
                    break;
                case ConsoleKey.Escape:
                    returnValue = (int)MenuOption.Exit;
                    break;
            }
        //}
        //Console.ForegroundColor = foregroundColor;
        return (MenuOption)returnValue;
        }


         private static void ManageDevices()
        {
            Console.WriteLine("Press b1 to turn the bulb1 on or off");
            Console.WriteLine("Press b2 to turn the bulb1 on or off");
            Console.WriteLine("Press b3 to turn the bulb1 on or off");
            Console.WriteLine("Press b4 to turn the bulb1 on or off");
        }
    }
}
