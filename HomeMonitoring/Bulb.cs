namespace HomeMonitoring
{
    public struct Bulb
    {
        /// <summary>
        /// Bulb Properties
        /// </summary>
        public string BulbId { get; set; }
        public string BulbType;
        public int BulbPower { get; set; }

        public int BulbLuminiscence { get; set; }

        public bool BulbOn { get; set; }


        
    }
}