using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double base1 = double.Parse(Console.ReadLine());
            double height1 = double.Parse(Console.ReadLine());
            double area =AreaOfTriangle(basis: base1, height: height1);
            Console.WriteLine($"{area}");
        }

        static double AreaOfTriangle(double basis, double height)
        {

            return height * basis / 2;
        }
    }
}
