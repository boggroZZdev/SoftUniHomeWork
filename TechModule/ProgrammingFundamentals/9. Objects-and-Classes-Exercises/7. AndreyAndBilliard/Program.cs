using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfEntities = int.Parse(Console.ReadLine());

            Dictionary<string, double> entities = new Dictionary<string, double>();

            for (int i = 0; i < countOfEntities; i++)
            {
                string[] entity = Console.ReadLine()
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (!entities.ContainsKey(entity[0]))
                {
                    entities.Add(entity[0], double.Parse(entity[1]));
                }
                else
                {
                    entities[entity[0]] = double.Parse(entity[1]);
                }
            }

            string[] input = Console.ReadLine()
                .Split(new char[] { '-', '-' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            SortedDictionary<string, Dictionary<string, double>> requests = new SortedDictionary<string, Dictionary<string, double>>();
            double bill = 0;
            while (input[0] != "end of clients")
            { 
                if (entities.ContainsKey(input[1]))
                {
                    if (requests.ContainsKey(input[0]))
                    {
                        if (requests[input[0]].ContainsKey(input[1]))
                        {
                            requests[input[0]][input[1]] += int.Parse(input[2]) * entities[input[1]];
                        }
                        else
                        {
                            requests[input[0]][input[1]] = int.Parse(input[2]) * entities[input[1]];
                        }
                        bill += requests[input[0]][input[1]];
                    }
                    else
                    {
                        requests.Add(input[0], new Dictionary<string, double>());
                        requests[input[0]][input[1]] = int.Parse(input[2]) * entities[input[1]];
                        bill += requests[input[0]][input[1]];
                    }
                }
                input = Console.ReadLine()
                    .Split(new char[] { '-', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            double totalBill = 0;
            foreach (var person in requests)
            {
                Console.WriteLine(person.Key);
                double personalBill = 0;
                foreach (var bildouble in person.Value)
                {

                    var finalQuantity = bildouble.Value / entities[bildouble.Key];
                    var product = bildouble.Key;
                    if (double.IsNaN(finalQuantity))
                    {
                        finalQuantity = 0;
                    }
                    Console.WriteLine($"-- {product} - {finalQuantity}");
                    personalBill += bildouble.Value;
                    totalBill += bildouble.Value;
                }
                Console.WriteLine($"Bill: {personalBill:f2}");
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> Order { get; set; }
        public double Bill { get; set; }
    }
}
