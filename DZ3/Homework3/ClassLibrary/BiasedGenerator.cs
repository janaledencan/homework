using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class BiasedGenerator : IRandomGenerator //pristrani
    {
        Random generator;

        public BiasedGenerator(Random generator)
        {
            this.generator = generator;
        }

        public double  GenerateValue(double minValue, double maxValue) 
        {
            double generatedValue = generator.NextDouble();

            if(generatedValue <= 0.66)
            {
                return (maxValue / 2 - minValue) * generatedValue + minValue; 
            }
            else
            {
                return (maxValue - minValue) * generatedValue + minValue;
            }
        }



    }
}
