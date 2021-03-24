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

     
        public enum BulbOnOff
        {
            BulbOn = 1,
            BulbOff = 2
        }
    }
}