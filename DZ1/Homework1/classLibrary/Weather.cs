using System;
using System.Collections.Generic;
using System.Text;

namespace classLibrary
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



    }
}
