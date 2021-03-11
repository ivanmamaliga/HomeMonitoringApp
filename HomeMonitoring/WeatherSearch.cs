using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeMonitoring
{

    public class WeatherSearch
    {
        public Coord coord { get; set; }

        [JsonProperty(PropertyName = "weather")]
        public List<Weather> Weather { get; set; }

        public string _base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    public class Coord
    {
        public float lon { get; set; }
        public float lat { get; set; }
    }

    public class Main
    {
        [JsonProperty(PropertyName = "temp") ]
        public float Temp { get; set; }
        [JsonProperty(PropertyName = "feels_like")]
        public float FeelsLike { get; set; }
        
        public float temp_min { get; set; }
        public float temp_max { get; set; }

        [JsonProperty(PropertyName = "Pressure")]
        public int Pressure { get; set; }

        [JsonProperty(PropertyName = "humidity")]
        public int Humidity { get; set; }
    }

    public class Wind
    {
        public float speed { get; set; }
        public int deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public float message { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
        public string icon { get; set; }
    }

}
