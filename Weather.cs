using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityStuff9000.Classes
{
    internal class Weather
    {
        private static Weather? _instance = null;
        public static Weather Instance { get {
                if (_instance == null) _instance = new Weather();
                return _instance; 
            }
        }
        public  CurrentWeatherModel CurrentWeather { get { return CurrentWeatherModel.Cloudy; } }
        public enum CurrentWeatherModel
        {
            Sunny,
            Rainy,
            Cloudy
        }
    }
}
