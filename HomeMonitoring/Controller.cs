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
                    Console.WriteLine("Area Not Activated, choose next: ");
                }
                else
                {
                    Console.WriteLine("Area Activated, choose options:  ");

                }
            }
           
        }
        public static void Activate(string activateInput)
        {
            Console.WriteLine($"Press [A] to activate the system ");
            Console.WriteLine($"Press [D] to desactivate the system ");
            activateInput = Console.ReadLine();
            //TODO: implement lambda expression
            if (activateInput == "A") 
            {
                activate = true;
                Console.WriteLine("The area is activated  ");
                Console.ReadKey();
            }
            else
            {
                activate = false;
                Console.WriteLine("The area is deactivated  ");
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
       


   
