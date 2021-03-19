namespace HomeMonitoring
{
    public class Bulb
    {
        /// <summary>
        /// Bulb Properties
        /// </summary>
        public string BulbType { get; set; }
        public int BulbPower { get; set; }

        public int BulbLuminiscence { get; set; } //not yet used

        public bool isBulbOn { get { return isBulbOn; } set { isBulbOn = false; } }

     
        public enum BulbOnOff
        {
            BulbOn = 1,
            BulbOff = 2
        }

        public string TurnBulbOn(bool isBulbOn)
        {
          
            if (!isBulbOn == false)
            {
               return "Bulb is On";
            }
            return "Bulb is Off";

        }


    }
}