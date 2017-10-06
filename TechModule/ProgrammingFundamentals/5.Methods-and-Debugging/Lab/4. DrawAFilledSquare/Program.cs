using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            TopAndBottomLine(input);
            MiddleLines(input);
            TopAndBottomLine(input);
        }

        static void TopAndBottomLine(int inputTimesTwo)
        {
            Console.WriteLine(new string('-', 2*inputTimesTwo));
        }

        static void MiddleLines(int whatever)
        {
            for (int j=1; j <=whatever-2; j++)
            {
                Console.Write('-');
                for (int i = 1; i < whatever; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');
            }
        }
    }
}
