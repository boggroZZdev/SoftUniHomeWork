using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWorks 
{
    class Program
    {
        static void Main(string[] args)
        {
            Header();
            Body();
            Footer();
        }

        static void Header()
        {
            Console.WriteLine("CASH RECEIPT\r\n------------------------------");
        }

        static void Body()
        {
            Console.WriteLine("Charged to____________________\r\nReceived by___________________");
        }

        static void Footer()
        {
            Console.WriteLine("------------------------------\r\n© SoftUni");
        }
    }
}
