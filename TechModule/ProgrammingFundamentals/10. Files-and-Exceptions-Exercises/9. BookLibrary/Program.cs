using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            Dictionary<string, double> output =new Dictionary<string, double>(); 

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = command[1];
                double price = double.Parse(command[5]);

                if (output.ContainsKey(name))
                {
                    output[name] += price;
                }
                else
                {
                    output[name] = price;
                }
            }

            var reworkedOutput = output.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            foreach (var keyValuePair in reworkedOutput)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value:F2}");
            }
        }
    }
}
