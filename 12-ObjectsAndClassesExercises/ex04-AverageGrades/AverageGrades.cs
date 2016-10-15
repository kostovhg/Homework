using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04_AverageGrades
{
    class Student
    {
        public string Name { get; set; }
        public double[] Grades { get; set; }

        public double Average
        {
            get
            {
                return Grades.Average();
            }
        }

        public Student(string studentAndGrades)
        {
            string[] studentGrades = studentAndGrades.Split().ToArray();
            Name = studentGrades[0];
            Grades = new double[studentGrades.Length - 1];
            for (int i = 1; i < studentGrades.Length; i++)
            {
                Grades[i - 1] = double.Parse(studentGrades[i]);
            }
        }
    }
    class AverageGrades
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                students.Add(new Student(Console.ReadLine()));
            }

            PrintStudentsWithAverageGrades(students);
        }

        private static void PrintStudentsWithAverageGrades(List<Student> students)
        {

            foreach (var student in students.Where(g => g.Average >= 5.00).OrderBy(s => s.Name).ThenByDescending(g => g.Average))
            {
                Console.WriteLine($"{student.Name} -> {student.Average:f2}");
            }
        }
    }
}
