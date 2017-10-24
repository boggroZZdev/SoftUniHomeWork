using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstThree = input.OrderByDescending(x => x).Take(3);
            Console.WriteLine(string.Join(" ",firstThree));
        }
    }
}
