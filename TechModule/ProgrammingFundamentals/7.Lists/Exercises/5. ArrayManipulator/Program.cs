using System;
using System.Collections.Generic;
using System.Linq;

namespace _5.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputLine = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<int> input = new List<int>();
            foreach (string number in inputLine)
            {
                input.Add(int.Parse(number));
            }
            while (true)
            {
                var command = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                switch (command[0])
                {
                    case "print":
                        Console.WriteLine($"[{string.Join(", ", input)}]");
                        return;
                    case "add":
                        int indexAdd = int.Parse(command[1]);
                        int elementAdd = int.Parse(command[2]);
                        input.Insert(indexAdd, elementAdd);
                        break;

                    case "addMany":
                        int indexAddMany = int.Parse(command[1]);

                        for (int i = 2; i < command.Count; i++)
                        {
                            int element = int.Parse(command[i]);
                            input.Insert(indexAddMany, element);
                            indexAddMany++;
                        }
                        break;

                    case "contains":
                        int elementContains = int.Parse(command[1]);
                        bool isFound = false;

                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == elementContains)
                            {
                                Console.WriteLine($"{i}");
                                isFound = true;
                                break;
                            }
                        }
                        if (!isFound)
                        {
                            Console.WriteLine("-1");
                        }
                        break;

                    case "remove":
                        if (command.Contains("remove"))
                        {
                            int indexRemove = int.Parse(command[1]);
                            input.RemoveAt(indexRemove);
                        }
                        break;

                    case "shift":
                        int positions = int.Parse(command[1]);

                        for (int i = 0; i < positions; i++)
                        {
                            int firstNumber = input[0];
                            for (int j = 0; j < input.Count - 1; j++)
                            {
                                input[j] = input[j + 1];
                            }
                            input[input.Count - 1] = firstNumber;
                        }
                        break;

                    case "sumPairs":
                        for (int i = 0; i < input.Count; i++)
                        {
                            int sum;

                            if (i + 1 < input.Count)
                            {
                                sum = input[i] + input[i + 1];
                                input[i] = sum;
                                input.RemoveAt(i + 1);
                            }
                            else
                            {
                                sum = input[i];
                                input[i] = sum;
                            }
                        }
                        break;
                }
            }
        }
    }
}
