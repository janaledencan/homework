using System;
using System.Collections.Generic;
using System.Text;

/* metodu koja omogućuje generiranje realne vrijednosti unutar raspona zadanog predanim argumentima*/

namespace ClassLibrary
{
    public interface IRandomGenerator
    {
        double GenerateValue(double minValue, double maxValue);
    }
}
