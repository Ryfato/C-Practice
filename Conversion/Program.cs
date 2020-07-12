using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperture Conversion");
            double celcius;
            double fahrenhit;
            double kelvin;
            for(int i=1; i<=20; i++)
            {
                celcius = 25 * i;
                Console.WriteLine( celcius+"C = "+Temperature.celciusToKelvin(celcius)+"K");
            }
            Console.ReadLine();
        }
    }
}
