using System;
using System.Collections.Generic;

namespace HomeMonitoring
{
    /// <summary>
    /// House Controller and Controller Methods
    /// </summary>
    public static class Controller
    {
        public static bool activate { get; set; } = false;

        public static void GetCurrentStatus()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            isActivated();

            static void isActivated()
            {

                if (Activated() != true)
                {
                    Console.WriteLine("Area Not Activated, please click any key to proceed ");
                }
                else
                {
                    Console.WriteLine("Area Activated, please click any key to proceed");

                }
            }
           
        }
        public static void Activate(string activateInput)
        {
            Console.WriteLine($"Press [A] to activate the system ");
            Console.WriteLine($"Press [D] to desactivate the system ");
            activateInput = Console.ReadLine();
            //TODO: implement lambda expression
            if (activateInput == "A" || activateInput == "a") 
            {
                activate = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The area is activated  ");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            else
            {
                activate = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The area is deactivated  ");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
        internal static bool Activated()
        {
            if (activate != false)
            {
                return true;
            }

            return default;
        }

    }
}
       


   
