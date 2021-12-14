using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ForecastUtilities
    {
        public static DailyForecast Parse(string forecast)
        {
            string[] words = forecast.Split(",");
            DateTime day = DateTime.Parse(words[0]);
            double dayTemperature = double.Parse(words[1]);
            double dayWindSpeed = double.Parse(words[2]);
            double dayHumidity = double.Parse(words[3]);

            Weather dayWeather = new Weather(dayTemperature, dayHumidity, dayWindSpeed);

            DailyForecast restoredDay = new DailyForecast(day, dayWeather);

            return restoredDay;
        }



        static Weather FindWeatherWithLargestWindchill(Weather[] weathers)
        {
            int i, indx = 0;
            double highestWindChill = weathers[0].CalculateWindChill();

            for (i = 1; i < weathers.Length; i++)
            {
                if (weathers[i].CalculateWindChill() > highestWindChill)
                {
                    highestWindChill = weathers[i].CalculateWindChill();
                    indx = i;
                }
            }
            return (weathers[indx]);
        }

        //T=34.407072087473736°C, w=0.7242330027391357km/h, h=21.260308903297553%
        public static void PrintWeathers(IPrinter[] printers, Weather[] weathers)
        {
            int i;

            for (i= 0; i<weathers.Length; i++)
            {
                printers[0].Print(weathers[i].ToString());
                printers[1].Print(weathers[i].ToString());

            }
           
        }
    }
}
