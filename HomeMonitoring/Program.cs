using System;

namespace HomeMonitoring
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user what he/she wants to do?

            Console.WriteLine("Hello! Please choose from next options: \n\r");



            Controller controller = new Controller();

            
            if (controller.GetStatus()!= true)
            {
                controller.Activate();
            }


            controller.AddRooms();
          

        }
    }
}
