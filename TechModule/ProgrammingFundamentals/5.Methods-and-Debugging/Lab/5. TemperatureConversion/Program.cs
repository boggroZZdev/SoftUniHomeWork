using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            var celsius = FahrenheitConverted(fahrenheit);
            Console.WriteLine($"{celsius:F2}");
        }

        static double FahrenheitConverted(double degrees)
        {
            return (degrees - 32) * 5 / 9;
        }
    }
}
