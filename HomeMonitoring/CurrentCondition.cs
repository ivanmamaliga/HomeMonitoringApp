using System;
using System.IO;
using System.Net;

namespace HomeMonitoring
{
    /// <summary>
    /// Implement Weather API
    /// </summary>
    internal class CurrentCondition

        
    {
        internal static void GetCurrentTime()
        {
            DateTime today = new DateTime();
            Console.WriteLine($"Today is {today}. "); //need some formatting
        }

        public static string GetWeather()
        {
            var webClient = new WebClient();
            var weatherSearch = webClient.DownloadData(string.Format("http://api.openweathermap.org/data/2.5/forecast?id=524901&appid=93734ddb4f9e3537074bd685674d8904"));

            using var stream = new MemoryStream(weatherSearch);
            using var reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }

        public static void GetCurrentCondition()
        {

        }
         
    }
}