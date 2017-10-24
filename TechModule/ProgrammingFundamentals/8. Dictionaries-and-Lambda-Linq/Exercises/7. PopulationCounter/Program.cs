using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> totalInfo = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split('|').ToArray();
                if (input[0] == "report")
                {
                    break;
                }
                string city = input[0];
                string country = input[1];
                long population = long.Parse(input[2]);

                if (!totalInfo.ContainsKey(country))
                {
                    totalInfo.Add(country, new Dictionary<string, long>());
                }
                totalInfo[country].Add(city, population);

            }

            totalInfo = totalInfo
                .OrderByDescending(x => x.Value.Values.Sum())
                .ToDictionary(x => x.Key, y => y.Value);
            foreach (var key in totalInfo)
            {
                Console.WriteLine($"{key.Key} (total population: {key.Value.Values.Sum()})");
                foreach (var city in key.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
