using System;

namespace _05_Temperature
{
    public interface ITemperature
    {
        double Convert(double v);
    }

    public class Celcius : ITemperature
    {
        public double Convert(double v)
        {
            return (v - 32) * 5 / 9;
        }
    }
    public class Fahrenheit : ITemperature
    {
        public double Convert(double v)
        {
            return v * 9 / 5 + 32;
        }
    }

}