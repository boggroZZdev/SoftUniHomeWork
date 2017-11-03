using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CountingSubstringOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string exception = Console.ReadLine().ToLower();

            int counter = 0;

            int index = input.IndexOf(exception);

            while (true)
            {
                index = input.IndexOf(exception, index + 1);
                counter++;
                if (index<0)
                {
                    break;
                }
                
            }

            Console.WriteLine(counter);
        }
    }
}
