using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            string command = Console.ReadLine();
            int quantity = 0;

            while (command!="stop")
            {
                if (!result.ContainsKey(command))
                {
                    quantity = int.Parse(Console.ReadLine());
                    result.Add(key:command, value:quantity);
                }
                else
                {
                    quantity = int.Parse(Console.ReadLine());
                    result[command] += quantity;
                }
                command = Console.ReadLine().ToLower();
            }

            foreach (string key in result.Keys)
            {
                Console.WriteLine($"{key} -> {result[key]}");
            }
        }
    }
}
