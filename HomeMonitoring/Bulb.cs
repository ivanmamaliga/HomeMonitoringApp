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

        public bool IsBulbOn { get { return IsBulbOn; } set { IsBulbOn = false; } }

     
     


    }
}