using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Student> output = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                Student person = new Student();
                string[] command = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = command[0];

                person.Name = name;

                double sum = 0;

                for (int j = 1; j < command.Length; j++)
                {
                    sum += double.Parse(command[j]);
                }

                double averageGrade = sum / (command.Length - 1);
                person.AverageGrade = averageGrade;

                output.Add(person);
            }

            var reworkedOuput = output.Where(x => x.AverageGrade >= 5).OrderBy(x => x.Name)
                .ThenByDescending(x => x.AverageGrade);

            foreach (var person in reworkedOuput)
            {
                Console.WriteLine($"{person.Name} -> {person.AverageGrade:F2}");
            }
        }
    }

    class Student
    {
        public double AverageGrade { get; set; }
        public string Name { get; set; }
    }
}
