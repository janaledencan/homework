using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class WeatherGenerator
    {
        double minTemperature;
        double maxTemperature;
        double minHumidity;
        double maxHumidity;
        double minWindSpeed;
        double maxWindSpeed;
        IRandomGenerator randomGenerator;

        public WeatherGenerator(double minTemperature, double maxTemperature, double minHumidity, double maxHumidity, double minWindSpeed, double maxWindSpeed, IRandomGenerator randomGenerator)
        {
            this.minTemperature = minTemperature;
            this.maxTemperature = maxTemperature;
            this.minHumidity = minHumidity;
            this.maxHumidity = maxHumidity;
            this.minWindSpeed = minWindSpeed;
            this.maxWindSpeed = maxWindSpeed;
            this.randomGenerator = randomGenerator;
        }

        public void SetGenerator(IRandomGenerator randomGenerator) { this.randomGenerator = randomGenerator; }

        public Weather Generate() 
        {
            double temperatureRandom = randomGenerator.GenerateValue(minTemperature,maxTemperature);
            double humidityRandom = randomGenerator.GenerateValue(minHumidity, maxHumidity); 
            double windSpeedRandom = randomGenerator.GenerateValue(minWindSpeed, maxWindSpeed); 


            return  new Weather(temperatureRandom, humidityRandom, windSpeedRandom);
        }

    }
}
