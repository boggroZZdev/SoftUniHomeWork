using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            Dictionary<string, int> outputSecond = new Dictionary<string, int>();

            output["shards"] = 0;
            output["fragments"] = 0;
            output["motes"] = 0;

            bool legendaryWon = true;

            while (legendaryWon)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ').ToArray();

                for (int i = 1; i <= input.Length - 1; i += 2)
                {
                    if (output.ContainsKey(input[i]))
                    {
                        output[input[i]] += int.Parse(input[i - 1]);
                    }
                    else
                    {
                        if (!outputSecond.ContainsKey(input[i]))
                        {
                            outputSecond[input[i]] = 0;
                        }

                        outputSecond[input[i]] += int.Parse(input[i - 1]);
                    }
                   
                    outputSecond = outputSecond
                        .OrderBy(x => x.Key)
                        .ToDictionary(x => x.Key, y => y.Value);

                    if (output["shards"] >= 250)
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        output["shards"] -= 250;
                        output = output
                            .OrderBy(x => x.Key)
                            .OrderByDescending(x => x.Value)
                            .ToDictionary(x => x.Key, x => x.Value);
                        foreach (var key in output)
                        {
                            Console.WriteLine($"{key.Key}: {key.Value}");
                        }

                        foreach (var key in outputSecond)
                        {
                            Console.WriteLine($"{key.Key}: {key.Value}");
                        }
                        legendaryWon = false;
                    }
                    else if (output["motes"] >= 250)
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        output["motes"] -= 250;
                        output = output
                            .OrderBy(x => x.Key)
                            .OrderByDescending(x => x.Value)
                            .ToDictionary(x => x.Key, x => x.Value);
                        foreach (var key in output)
                        {
                            Console.WriteLine($"{key.Key}: {key.Value}");
                        }

                        foreach (var key in outputSecond)
                        {
                            Console.WriteLine($"{key.Key}: {key.Value}");
                        }
                        legendaryWon = false;
                    }
                    else if (output["fragments"] >= 250)
                    {
                        Console.WriteLine("Valanyr obtained!");
                        output["fragments"] -= 250;
                        output = output
                            .OrderBy(x => x.Key)
                            .OrderByDescending(x => x.Value)
                            .ToDictionary(x => x.Key, x => x.Value);
                        foreach (var key in output)
                        {
                            Console.WriteLine($"{key.Key}: {key.Value}");
                        }

                        foreach (var key in outputSecond)
                        {
                            Console.WriteLine($"{key.Key}: {key.Value}");
                        }
                        legendaryWon = false;
                    }
                }
            }
        }
    }
}
