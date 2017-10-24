using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            short n = short.Parse(Console.ReadLine());

            SortedDictionary<string, SortedDictionary<string, int>> output = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                string name = input[1];
                string ip = input[0];
                int seconds = int.Parse(input[2]);

                if (!output.ContainsKey(name))
                {
                    output.Add(name, new SortedDictionary<string, int>());
                }
                if (!output[name].ContainsKey(ip))
                {
                    output[name][ip] = 0;
                }
                output[name][ip] += seconds;
            }


            foreach (var name in output)
            {
                Console.Write($"{name.Key}: {name.Value.Values.Sum()} [{string.Join(", ", name.Value.Keys)}]");
                Console.WriteLine();
            }
        }
    }
}
