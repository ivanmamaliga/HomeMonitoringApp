using System.Collections.Generic;

namespace HomeMonitoring
{
    internal class Room
    {
        public string Id { get; set; }
        public int numberOfBulbs { get; set; }

        public int numberOfVents { get; set; }

       
        internal Room()
        {

        }

       

        public List<Bulb> GetBulbs()
        {

            Bulb bulb1 = new Bulb() { BulbType = "Regular", BulbLuminiscence = 1200, BulbPower = 35 };
            Bulb bulb2 = new Bulb() { BulbType = "Regular", BulbLuminiscence = 2200, BulbPower = 55 };
            Bulb bulb3 = new Bulb() { BulbType = "Regular", BulbLuminiscence = 2300, BulbPower = 75 };
            Bulb bulb4 = new Bulb() { BulbType = "Regular", BulbLuminiscence = 2500, BulbPower = 100 };
            List<Bulb> bulbs = new List<Bulb>() { bulb1, bulb2, bulb3, bulb4 };
            return bulbs;

        }

      
        public List<Vent> GetVent()
        {
            Vent vent1 = new Vent();
            Vent vent2 = new Vent();
            Vent vent3 = new Vent();


            List<Vent> vents = new List<Vent>() { vent1, vent2, vent3 };

            return vents;

        }
        //public static void GetBulbStatus()
        //{
        //    if (!IsBulbOn == true)
        //    {
        //        System.Console.WriteLine("True");
        //    }
        //    System.Console.WriteLine("False");
        //}
        //public static TurnBulbOn(Bulb bulb)
        //{
        //    if (!IsBulbOn == true)
        //    {
        //        return bulb;
        //    }

        //}

        //public static TurnBulbOff(Bulb bulb)
        //{
        //    if (!IsBulbOn == true)
        //    {
        //        return IsBulbOn = false;
        //    }

        //}
    }
}
