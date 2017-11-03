using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> emails = new Dictionary<string, string>();

            string name = Console.ReadLine();

            while (name!="stop")
            {
                string[] email = Console.ReadLine().Split('.').ToArray();

                if (emails.ContainsKey(name))
                {
                    if (!email.Contains("us")&&!email.Contains("uk"))
                    {
                        emails[name] = string.Join(".", email);
                    }
                }
                else
                {
                    if (!email.Contains("us") && !email.Contains("uk"))
                    {
                        emails[name] = string.Join(".", email);
                    }
                }
                
                name = Console.ReadLine();
            }

            foreach (var pair in emails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
