using System;

namespace HomeMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user what he/she wants to do?

            Console.WriteLine("Hello! Please choose from next options: \n\r");
            Console.WriteLine("1 - Check the system if it is armed\n\r");
            Console.WriteLine("2 - Activate the system\n\r");
            Console.WriteLine("3 - Choose the room\n\r");
            Console.WriteLine("4 - Manage the devices\n\r");



            Controller controller = new Controller();

            
            if (controller.GetStatus()!= true)
            {
                controller.Activate();
            }


            controller.AddRooms();
          

        }
    }
}
