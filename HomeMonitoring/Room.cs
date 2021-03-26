using System.Collections.Generic;

namespace HomeMonitoring
{
    public class Room
    {
        //private string bulb;
        public Bulb BulbInc { get; set; }
        public string Id { get; set; }
        public int numberOfBulbs { get; set; }
        public int numberOfVents { get; set; }


        public List<Bulb> bulbs = new List<Bulb>()
        { new Bulb() {BulbId = "1001", BulbType = "incadescent", BulbLuminiscence = 1200},
          new Bulb() {BulbId = "1002", BulbType = "incadescent", BulbLuminiscence = 2400}
        };

        
       

        

    }
}
