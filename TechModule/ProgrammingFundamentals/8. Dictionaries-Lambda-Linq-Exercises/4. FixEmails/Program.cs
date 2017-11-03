using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailDict = new Dictionary<string, string>();

            string command = Console.ReadLine();
            List<string> email = new List<string>();

            while (command!="stop")
            {
                email = Console.ReadLine().Split('.').ToList();

                if (!email.Contains("us")&&!email.Contains("uk"))
                { 
                    if (emailDict.ContainsKey(command))
                    {
                        emailDict[command] = string.Join(".", email);
                    }
                    else
                    {
                        emailDict.Add(key: command, value: string.Join(".", email));
                    }
                }
                command = Console.ReadLine();
            }

            foreach (string key in emailDict.Keys)
            {
                Console.WriteLine($"{key} -> {emailDict[string.Join("", key)]}");
            }
        }
    }
}
