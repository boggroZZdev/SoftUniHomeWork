using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.reversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = Console.ReadLine()[0];
            char b = Console.ReadLine()[0];
            char c = Console.ReadLine()[0];
            Console.WriteLine($"{c}{b}{a}");
        }
    }
}
