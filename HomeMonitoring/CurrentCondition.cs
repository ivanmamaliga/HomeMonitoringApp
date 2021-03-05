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
            Console.WriteLine($"Today is {today}. "); //needs some formatting
        }

        public static void GetCurrentConditions()
        {
            var webClient = new WebClient();
            byte[] weatherSearch = webClient.DownloadData(string.Format("http://api.openweathermap.org/data/2.5/weather?q=Louisville&appid=a479fe317c41285915790dc6497a2b3c&units=imperial"));

            //string results = String.Empty;
            var serializer = new JsonSerializer();
            using var stream = new MemoryStream(weatherSearch);
            using var reader = new StreamReader(stream);
            using var jsonReader = new JsonTextReader(reader);
            var results = serializer.Deserialize<WeatherSearch>(jsonReader);
            
            Console.WriteLine($"The temp is {results.main.Temp}");

            Console.ReadLine();
        
            //return reader.ReadToEnd();
        }

        
         
    }
}