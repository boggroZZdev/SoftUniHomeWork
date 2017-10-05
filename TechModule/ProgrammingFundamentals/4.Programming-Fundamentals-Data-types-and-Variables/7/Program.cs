using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Practice_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
            int c = b;
            b = a;
            a = c;
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}
