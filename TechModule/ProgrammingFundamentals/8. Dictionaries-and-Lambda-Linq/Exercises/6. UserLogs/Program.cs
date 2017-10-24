using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> allUsers = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "end")
                {
                    break;
                }
                string[] ipArray = input[0].Split('=').ToArray();
                string ip = ipArray[1];
                string[] userArray = input[2].Split('=').ToArray();
                string username = userArray[1];
                if (!allUsers.ContainsKey(username))
                {
                    allUsers[username] = new Dictionary<string, int>();
                    allUsers[username].Add(ip,1);
                }
                else
                {
                    if (allUsers[username].ContainsKey(ip))
                    {
                        allUsers[username][ip]++;
                    }
                    else
                    {
                        allUsers[username].Add(ip,1);
                    }
                }
            }
            foreach (var key in allUsers.Keys)
            {
                Console.WriteLine($"{key}:");
                foreach (string value in allUsers[key].Keys) 
                {

                    if (allUsers[key].Keys.Count==1)
                    {
                        Console.WriteLine($"{value} => {allUsers[key][value]}.");
                    }
                    else
                    {
                        if (value != allUsers[key].Keys.Last())
                        {
                            Console.Write($"{value} => {allUsers[key][value]}, ");
                        }
                        else
                        {
                            Console.Write($"{value} => {allUsers[key][value]}.");
                            Console.WriteLine();
                        }
                    }
                   
                }
            }
        }
    }
}
