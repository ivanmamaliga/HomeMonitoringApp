using System.Collections.Generic;

namespace HomeMonitoring
{
    internal class Room 
    {
         
        public void GetBulbs()
        {
            
            Bulb bulb1 = new Bulb() { BulbType = "Regular", BulbLuminiscence = 1200, BulbPower = 35};
            Bulb bulb2 = new Bulb() { BulbType = "Regular", BulbLuminiscence = 2200, BulbPower = 55};
            Bulb bulb3 = new Bulb() { BulbType = "Regular", BulbLuminiscence = 2300, BulbPower = 75};
            Bulb bulb4 = new Bulb() { BulbType = "Regular", BulbLuminiscence = 2500, BulbPower = 100};

            List<Bulb> bulbs = new List<Bulb>() { bulb1, bulb2, bulb3, bulb4 };

        }

        public void GetVentPosition()
        {

        }
      

       
        


    }
}