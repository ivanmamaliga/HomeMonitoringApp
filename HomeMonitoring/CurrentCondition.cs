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
            DateTime today = DateTime.Now;
            Console.WriteLine(value: $"Today is {today:F}. ");
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
            ConsoleColor foregroundColor = Console.ForegroundColor;
            Console.WriteLine($"The temp is {results.WeatherMain.Temp} deg Fahrenheight.");
            var tempInCelcius = (ConvertFahrenheitToCelsuis(results.WeatherMain.Temp)).ToString("0.00");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"The temp is {tempInCelcius} deg Celcius.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Feels like {results.WeatherMain.FeelsLike} deg Fahrenheight.");
            var feelsLike = (ConvertFahrenheitToCelsuis(results.WeatherMain.FeelsLike)).ToString("0.00");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Feels like {feelsLike} deg Celcius.");
        }

        public static float ConvertFahrenheitToCelsuis(float fahrenheit)
        {
            return (float)((fahrenheit - 32.0) / 1.8);
        }


    }
}