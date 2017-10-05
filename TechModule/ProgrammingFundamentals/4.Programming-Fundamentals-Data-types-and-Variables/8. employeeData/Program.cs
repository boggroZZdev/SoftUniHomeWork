using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.employeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string name2 = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = Console.ReadLine()[0];
            long id = long.Parse(Console.ReadLine());
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {name}\r\nLast name: {name2}\r\nAge: {age}\r\nGender: {gender}\r\nPersonal ID: {id}\r\nUnique Employee number: {number}");
        }
    }
}
