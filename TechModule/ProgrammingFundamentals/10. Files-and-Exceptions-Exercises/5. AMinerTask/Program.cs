using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> preciousMetals = new Dictionary<string, int>();

            string metal = Console.ReadLine();

            while (metal!= "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (preciousMetals.ContainsKey(metal))
                {
                    preciousMetals[metal] += quantity;
                }
                else
                {
                    preciousMetals[metal] = quantity;
                }
                metal = Console.ReadLine();
            }

            foreach (var metals in preciousMetals)
            {
                Console.WriteLine($"{metals.Key} -> {metals.Value}");
            }
        }
    }
}
