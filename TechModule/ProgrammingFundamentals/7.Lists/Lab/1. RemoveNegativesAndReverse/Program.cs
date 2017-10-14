using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            bool isFound = false;

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i]>=0&& !(input[i]<0))
                {
                    result.Add(input[i]);
                    isFound = true;
                }    
            }
            if (isFound)
            {
                result.Reverse();
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
            
        }
    }
}
