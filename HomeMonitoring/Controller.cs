using System;
using System.Collections.Generic;

namespace HomeMonitoring
{
    /// <summary>
    /// House Controller and Controller Methods
    /// </summary>
    public static class Controller
    {
        private static IEnumerable<Room> rooms;


        //private readonly TemperatureSensor _temperatureSensor;        

        internal static void Activate()
        {

        }
        public static void GetStatus()
        {
          
            foreach (Room rm in rooms)
            {
                // get the Number, Type and Properties of the bulb

                //check for the bulb if on/of

                //Output like Bedroom 1 - bulb 1 is on
                //                    2 - bulb 2 is off ..   


            }


        }
    }
}