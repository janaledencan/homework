using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    public class WeeklyForecast
    {
        private DailyForecast[] weatherForSevenDays;

        public WeeklyForecast(DailyForecast[] weatherForSevenDays)
        {
            this.weatherForSevenDays = weatherForSevenDays;
        }

        public string GetAsString()
        {
            return $"{weatherForSevenDays[0].GetAsString()}\n" +
                      $"{weatherForSevenDays[1].GetAsString()}\n" +
                      $"{weatherForSevenDays[2].GetAsString()}\n" +
                      $"{weatherForSevenDays[3].GetAsString()}\n" +
                      $"{weatherForSevenDays[4].GetAsString()}\n" +
                      $"{weatherForSevenDays[5].GetAsString()}\n" +
                      $"{weatherForSevenDays[6].GetAsString()}";
        }

            
        public double GetMaxTemperature()
        {
            Weather maxTemperature = weatherForSevenDays[0].GetDayWeather();
            int i;

            for (i = 0; i < weatherForSevenDays.Length; i++)
            {
                if (weatherForSevenDays[i].GetDayWeather() > maxTemperature)
                {
                    maxTemperature = weatherForSevenDays[i].GetDayWeather();
                }    
            }
            return maxTemperature.GetTemperature();
        }

        public DailyForecast this[int index] { get { return weatherForSevenDays[index]; } }
    }
}
