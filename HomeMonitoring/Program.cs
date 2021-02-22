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

            //ask the user what he/she wants to do?

            Console.WriteLine("Hello! Please choose from next options: \n\r");
            Console.WriteLine("1 - Check the system if it is armed\n\r");
            Console.WriteLine("2 - Activate the system\n\r");
            Console.WriteLine("3 - Choose the room\n\r");
            Console.WriteLine("4 - Manage the devices\n\r");



                    
            if (Controller.GetStatus!= true)
            {
                Controller.Activate();
            }

        

        }
    }
}
