using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = GetStudents();
            string[] exellent = students
                .Where(x => x.AverageGrade >= 5)
                .Select(x => x.Name)
                .OrderBy(x => x)
                .Distinct()
                .ToArray();

            foreach (string student in exellent)
            {
                double[] studentAverageGrades = students
                    .Where(x => x.Name == student && x.AverageGrade >= 5)
                    .Select(x => x.AverageGrade)
                    .OrderByDescending(x => x)
                    .ToArray();
                foreach (double grade in studentAverageGrades)
                {
                    Console.WriteLine($"{student} -> {grade:F2}");
                }
            }
        }

        private static Student[] GetStudents()
        {
            int count = int.Parse(Console.ReadLine());
            Student[] grades = new Student[count];
            for (int i = 0; i < count; i++)
            {
                List<double> studentGrades = new List<double>();
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 1; j < input.Length; j++)
                {
                    studentGrades.Add(double.Parse(input[j]));
                }

                grades[i] = new Student() {Name = input[0], Grades = studentGrades};
            }
            return grades;
        }
    }

    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get { return (double)Grades.Sum() / Grades.Count; }
        }

    }
}
