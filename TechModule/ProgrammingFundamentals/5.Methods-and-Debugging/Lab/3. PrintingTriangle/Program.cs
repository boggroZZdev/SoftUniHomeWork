using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            Triangle(a);
        }

        static void Triangle(int triangleType)
        {
            TopPart(triangleType);
            BottomPart(triangleType);

        }

        static void TopPart(int top)
        {
            for (int i = 1; i <= top; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        static void BottomPart(int top)
        {
            for (int i = top-1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
