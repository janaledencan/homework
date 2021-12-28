using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class DailyForecast
    {
        private DateTime day;
        private Weather dayWeather;

        public Weather Weather { get{ return dayWeather; } }
        public DateTime GetDay() { return day; }

        public DailyForecast(DateTime day, Weather dayWeather)
        {
            this.day = day;
            this.dayWeather = dayWeather;
        }

        public override string ToString()
        {
            return $"{day.ToString("dd/MM/yyyy HH:mm:ss")}{dayWeather.ToString()}";
        }
    }
}
