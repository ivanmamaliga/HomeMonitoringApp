using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

        public static List<Weather> GetWeather()
        {
            
            var webClient = new WebClient();
            var weatherSearch = webClient.DownloadData(string.Format("http://api.openweathermap.org/data/2.5/forecast?id=524901&appid=93734ddb4f9e3537074bd685674d8904"));

            var results = new List<Weather>();
            var serializer = new JsonSerializer();
            using var stream = new MemoryStream(weatherSearch);
            using var reader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(reader);
            return results = serializer.Deserialize<WeatherSearch>(jsonReader).Weather;
            //return reader.ReadToEnd();
        }

        
         
    }
}