using System;

namespace _05_Temperature
{
    internal class TemperatureFactory
    {
        internal static ITemperature Get(Unit v)
        {
            if (v == Unit.Celcius)
            {
                return new Celcius();
            }
            else
            {
                return new Fahrenheit();
            }
        }
    }
}