using System;

namespace Fruits.API.Controllers
{
    public class WeatherForecast
    {
        internal string Summary;

        public DateTime Date { get; internal set; }
        public int TemperatureC { get; internal set; }
    }
}