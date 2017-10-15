using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int[] parameters = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isFound = false;

            input.RemoveRange(parameters[0],input.Count- parameters[0]);

            for (int i = 0; i < parameters[1]; i++)
            {
                input.RemoveAt(0);
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]==parameters[2])
                {
                    isFound = true;
                }
            }

            if (isFound)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }    
    }
}
