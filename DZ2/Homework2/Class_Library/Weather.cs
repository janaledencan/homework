using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Library
{
    class Weather
    {
        private double temperature;
        private double windSpeed;
        private double humidity;

        public double GetTemperature() { return temperature; }
        public double GetWindSpeed() { return windSpeed; }
        public double GetHumidity() { return humidity; }

        public void SetTemperature(double temperature) { this.temperature = temperature; }
        public void SetWindSpeed(double windSpeed) { this.windSpeed = windSpeed; }
        public void SetHumidity(double humidity) { this.humidity = humidity; }


        public Weather()
        {
            this.temperature = 21.0;
            this.windSpeed = 0;
            this.humidity = 2;
        }

        public Weather(double temperature, double humidity, double windSpeed)
        {
            this.temperature = temperature;
            this.windSpeed = windSpeed;
            this.humidity = humidity;
        }

        public double CalculateFeelsLikeTemperature()
        {
            double relHumidity = humidity;
            return (Constants.c1 + (Constants.c2 * temperature) + (Constants.c3 * relHumidity) + (Constants.c4 * temperature * relHumidity) + (Constants.c5 * Math.Pow(temperature, 2)) + (Constants.c6 * Math.Pow(relHumidity, 2)) + (Constants.c7 * Math.Pow(temperature, 2) * relHumidity) + (Constants.c8 * temperature * Math.Pow(relHumidity, 2)) + (Constants.c9 * Math.Pow(temperature, 2) * Math.Pow(relHumidity, 2)));
        }

        public double CalculateWindChill()
        {
            double windChillIndx = 13.12 + (0.6215 * temperature) - (11.37 * Math.Pow(windSpeed, 0.16)) + (0.3965 * temperature * Math.Pow(windSpeed, 0.16));

            if (this.temperature > 10 || this.windSpeed < 4.8)
            {
                windChillIndx = 0;
                return windChillIndx;
            }
            return windChillIndx;
        }

        public string GetAsString()
        {
            return $"T={temperature}°C, w={windSpeed}km / h, h={humidity}%";
        }
    }
}
