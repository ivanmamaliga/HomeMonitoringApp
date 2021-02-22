using System;
using System.Reflection;

//[assembly: AssemblyDescription("Home Monitoring App")]

namespace HomeMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {

            //Assembly thisAssem = typeof(Program).Assembly;

            //AssemblyName thisAssemName = thisAssem.GetName();

            //Version thisAssemVersion = thisAssemName.Version;

            //object[] attributes = thisAssem.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);

            //var thisAssemDescriptionAttribute = attributes[0] as AssemblyDescriptionAttribute;

            //Console.WriteLine($"Assembly Name: {thisAssemName}");
            //Console.WriteLine($"Assembly Version: {thisAssemVersion}");

            //if (thisAssemDescriptionAttribute != null)
            //    Console.WriteLine($"Assembly Description: {thisAssemDescriptionAttribute.Description}");


            //Display the current condition : time of the day, outside temeperature - implement the weather API

            Console.WriteLine("Hello! Please choose from next options: \n\r");
            Console.WriteLine("1 - Check the Status\n\r");
            Console.WriteLine("2 - Activate the system\n\r");
            Console.WriteLine("3 - Choose the room\n\r");
            Console.WriteLine("4 - Manage the devices\n\r");

            Console.ReadKey();
            {
                Controller.GetStatus();
            }

            Controller.Activate();

            Controller.GetStatus();

            Console.WriteLine("Press b1 to turn the bulb1 on or off" );
            Console.WriteLine("Press b2 to turn the bulb1 on or off" );
            Console.WriteLine("Press b3 to turn the bulb1 on or off" );
            Console.WriteLine("Press b4 to turn the bulb1 on or off" );



            

        }
    }
}
