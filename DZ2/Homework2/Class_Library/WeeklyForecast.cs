using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    class WeeklyForecast
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

        //Kod usporedbe pri traženju vremena s najvećom temperaturom koristiti
        //odgovarajući preopterećeni relacijski operator (uspoređuje se prema temperaturi).

        public static bool operator >(Weather firstValue, Weather secondValue)
        {
            double first = firstValue.GetTemperature();
            double second = secondValue.GetTemperature();
            return (first > second) ? true : false;

        }

        public static bool operator <(Weather firstValue, Weather secondValue)
        {
            return ((firstValue.GetTemperature()) < (secondValue.GetTemperature())) ? true : false;
        }

        public static bool operator <=(Weather firstValue, Weather secondValue)
        {
            return (firstValue.GetTemperature() < secondValue.GetTemperature()) ? true : false;
        }

        public static bool operator >=(Weather firstValue, Weather secondValue)
        {
            return (firstValue.GetTemperature() < secondValue.GetTemperature()) ? true : false;
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
                return $"{maxTemperature.GetTemperature()}";
            }

        }
    }
}
