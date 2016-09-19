using System;

namespace _05_Temperature
{
    public enum Unit { Celcius, Fahrenheit}
    

    public class Temperature
    {
        //private Unit celcius;
        //private double v;

        public Temperature()
        {

        }

        public Temperature(Unit skala, double v)
        {
            //this.celcius = celcius;
            //this.v = v;
            if (skala == Unit.Celcius) Celcius = v;
            if (skala == Unit.Fahrenheit) Fahrenheit = v;
            
        }

        public double Fahrenheit { get; internal set; }
        public double Celcius { get; internal set; }

        internal static double FahrenheitToCelcius(double v)
        {
            return (v-32)*5/9;
        }

        internal static double CelciusToFahrenheit(double v)
        {
            return v*9/5+32;
        }
    }
}