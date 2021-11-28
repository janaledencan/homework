using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    class DailyForecast
    {
        private DateTime day;
        private Weather dayWeather;

        public Weather GetDayWeather() { return dayWeather; }


        public DailyForecast(DateTime day, Weather dayWeather)
        {
            this.day = day;
            this.dayWeather = dayWeather;
        }

        public string GetAsString()
        {
            return $"{day.ToString()}{dayWeather.GetAsString()}";
        }
    }
}
