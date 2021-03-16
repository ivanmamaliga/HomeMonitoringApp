using System;
using System.Linq;
using System.Reflection;

//[assembly: AssemblyDescription("Home Monitoring App")]

namespace HomeMonitoring
{
    class Program

    {
        static void Main(string[] args)
        {
            
            CurrentCondition.GetCurrentTime();

            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"  _   _                        __  __             _ _             _             ");
            Console.WriteLine(@" | | | | ___  _ __ ___   ___  |  \/  | ___  _ __ (_) |_ ___  _ __(_)_ __   __ _ ");
            Console.WriteLine(@" | |_| |/ _ \| '_ ` _ \ / _ \ | |\/| |/ _ \| '_ \| | __/ _ \| '__| | '_ \ / _` |");
            Console.WriteLine(@" |  _  | (_) | | | | | |  __/ | |  | | (_) | | | | | || (_) | |  | | | | | (_| |");
            Console.WriteLine(@" |_| |_|\___/|_| |_| |_|\___| |_|  |_|\___/|_| |_|_|\__\___/|_|  |_|_| |_|\__, |");
            Console.WriteLine(@"                                                                          |___/ "); Console.WriteLine("");
            Console.WriteLine();

            CurrentCondition.GetCurrentConditions();
            Console.WriteLine();

            var exit = false;
            while (!exit)
            {
                switch (ProvideMenuOptions())
                {
                    case MenuOption.CheckTheStatus:
                        Controller.GetCurrentStatus();
                        //Console.WriteLine("Press any key continue...");
                        Console.WriteLine("Press any key to return to menu.");            
                        Controller.Activate(Console.ReadLine());
                        break;
                    case MenuOption.ChooseRoom:
                        Area.SetNumberOfRooms();
                        //Console.WriteLine("Press any key continue...");
                        //Console.ReadKey();
                        break;
                    case MenuOption.ManageDevices:
                        ManageDevices();
                        //Console.WriteLine("Press any key continue...");
                        //Console.ReadKey();
                        break;
                    case MenuOption.Exit:
                        exit = true;
                        break;
                }
            }

        }

        
        private static MenuOption ProvideMenuOptions()
        {

            
            int returnValue = -1;

            int minOptionValue = (int)Enum.GetValues(typeof(MenuOption)).Cast<MenuOption>().First();
            int maxOptionValue = (int)Enum.GetValues(typeof(MenuOption)).Cast<MenuOption>().Last();
            while (returnValue < minOptionValue || returnValue > maxOptionValue)
            {
                //Console.Clear();
                //Console.WriteLine();
               

           

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Choose the option to run:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t [1]  CheckTheStatus");
                Console.WriteLine("\t [2]  ChooseRoom (not implemented)");
                Console.WriteLine("\t [3]  ManageDevices");
                Console.WriteLine("\t[ESC] Exit");
                //Console.ForegroundColor = foregroundColor;
                var keyPress = Console.ReadKey(true);
                //int returnValue;
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
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        returnValue = (int)MenuOption.ManageDevices;
                        break;
                    case ConsoleKey.Escape:
                        returnValue = (int)MenuOption.Exit;
                        break;
                }
            }
            //Console.ForegroundColor = foregroundColor;
            return (MenuOption)returnValue;
        
        }
    
       


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
