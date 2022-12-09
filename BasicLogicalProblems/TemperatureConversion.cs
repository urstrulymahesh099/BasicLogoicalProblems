using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProblems
{
    internal class TemperatureConversion
    {
        public static void Temp()
        {
            double finalTemperature = 0;
            Console.WriteLine("1. Celsius to Fahrenheit" + "\n" + "2. Fahrenheit To Celsius ");
            int temp = Convert.ToInt32(Console.ReadLine());

            switch (temp)
            {
                case 1:
                    Console.WriteLine("Enter Temp in °C ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    finalTemperature = (c * 9 / 5) + 32;
                    Console.WriteLine(finalTemperature + "°F");
                    break;
                case 2:
                    Console.WriteLine("Enter Temp in °F ");
                    double f = Convert.ToDouble(Console.ReadLine());
                    finalTemperature = (f - 32) * 5 / 9;
                    Console.WriteLine(finalTemperature + "°C");
                    break;
            }
        }

    }
}