using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace MentorGroupSpace
{
    class Student
    {
        public string Name { get; set; }
        public List<DateTime> Attendency { get; set; }
        public List<string> Comments { get; set; }
    }

    class MentorGroup
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            var dicStudents = ReadInputOfStudentsAttendancy(number);

            string inputLine = Console.ReadLine();

            CollectCommentsForStudents(inputLine, dicStudents);

            PrintOutput(dicStudents);

        }

        private static void PrintOutput(SortedDictionary<string, Student> dicStudents)
        {
            foreach (var student in dicStudents.Keys)
            {
                Console.WriteLine(student);
                Console.WriteLine("Comments:");
                foreach (var comment in dicStudents[student].Comments)
                {
                    Console.WriteLine($"- {comment}");
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in dicStudents[student].Attendency.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date:dd/MM/yyyy}");
                }
            }
        }

        private static void CollectCommentsForStudents(string inputLine, SortedDictionary<string, Student> dicStudent)
        {

            while (!inputLine.Equals("end of comments"))
            {
                string[] input = inputLine.Split('-');
                string currentName = input[0];
                string currentComment = input[1];
                if (!dicStudent.ContainsKey(currentName))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                dicStudent[currentName].Comments.Add(currentComment);

                inputLine = Console.ReadLine();
            }
        }

        private static SortedDictionary<string, Student> ReadInputOfStudentsAttendancy(int numberOfTeams)
        {
            SortedDictionary<string, Student> dicStudents = new SortedDictionary<string, Student>();

            string inputLine = Console.ReadLine();

            while (!inputLine.Equals("end of dates"))
            {
                //Student student = new Student(); // create empty object of class Student

                string[] input = inputLine.Split(new char[] { ' ', ',' });
                string name = input[0];
                if (!dicStudents.ContainsKey(name))
                {
                    dicStudents.Add(name, new Student());
                    dicStudents[name].Name = name;
                    dicStudents[name].Attendency = new List<DateTime>();
                    dicStudents[name].Comments = new List<string>();
                }
                if (input.Length > 1)
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        dicStudents[name].Attendency.Add(DateTime.ParseExact(input[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                }


                inputLine = Console.ReadLine();
            }

            return dicStudents;
        }
    }
}