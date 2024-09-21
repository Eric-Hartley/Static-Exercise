using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempInF)
        {
            // (32°F − 32) × 5/9 = 0°C
            return (tempInF - 32) * 5 / 9;
        }
        public static double CelsiusToFahrenheit(double tempInC)
        {
            //(0°C × 9/5) + 32 = 32°F

            return (tempInC * 9 / 5) + 32;
        }
    }
}
