using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToArray();
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string word in input)
            {
                if (result.ContainsKey(word))
                {
                    result[word]++;
                }
                else
                {
                    result[word] = 1;
                }
            }
            
            var output = new List<string>();
            foreach (var pair in result)
            {
                if (pair.Value%2!=0)
                {
                    output.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", output));
        }
    }
}
