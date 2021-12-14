using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class UniformGenerator : IRandomGenerator //uniformni
    {
        Random generator;

        public UniformGenerator(Random generator)
        {
            this.generator = generator;
        }


        public double GenerateValue(double minValue, double maxValue)
        {
            return (maxValue-minValue)*generator.NextDouble() + minValue;

        }

    }
}
