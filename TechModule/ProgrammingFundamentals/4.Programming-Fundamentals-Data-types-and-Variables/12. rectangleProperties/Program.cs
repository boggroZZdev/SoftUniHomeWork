using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.rectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            var perimeter = 2 * width + 2 * height;
            Console.WriteLine(perimeter);
            var area = width * height;
            Console.WriteLine(area);
            var diagonal = Math.Sqrt((width * width) + (height * height));
            Console.WriteLine(diagonal);
        }
    }
}
