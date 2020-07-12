using System;
using System.Collections.Generic;
using System.Text;

namespace Conversion
{
    static class Temperature
    {
        //Convert Celcius to Fahrenhit
        public static double celciusToFahrenhit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
        // Convert Fahrenhit to Celcius
        public static double fahrenhitToCelcius(double fahrenhit)
        {
            return (fahrenhit- 32) *5 / 9;
        }
        public static double celciusToKelvin(double celcius)
        {
            return celcius + 273.15;
        }
        public static double kelvinToCelcius(double kelvin)
        {
            return kelvin - 273.15;
        }
    }
}
