using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.integerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string b = a.ToString("X");
            Console.WriteLine(b);
            var result = Convert.ToString(a, 2);
            Console.WriteLine(result);
        }
    }
}
