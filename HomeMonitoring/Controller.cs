using System;
using System.Collections.Generic;

namespace HomeMonitoring
{
    /// <summary>
    /// House Controller and Controller Methods
    /// </summary>
    public static class Controller
    {
        //private readonly TemperatureSensor _temperatureSensor;   



        public static void GetStatus()
        {
            Area _area1 = new Area();

            Room _room = new Room();

            //foreach (Room room in _area1.GetRooms())
            //{
            //    Room _room = new Room();
            // get the Number, Type and Properties of the bulb
            foreach (Bulb bulb in _room.GetBulbs())
            {
                //return bulb.GetBulbStatus();
            }

            //     //check for the bulb if on/of

            //     //Output like Bedroom 1 - bulb 1 is on
            //     //                    2 - bulb 2 is off ..   


        }


    }
}
       


   
