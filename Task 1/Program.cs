using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            for (var i = 0; i < 11; i++)
            {
                students.Add(new Student($"StudentFirstName-{i}", $"StudentLastName-{i}", new Mark[4]));
            }


            Random r = new Random();
            foreach (Student std in students)
            {
                for (var i = 0; i <= 3; i++)
                {
                    std.Marks[i] = new Mark("Subject" + (i), r.Next(0, 10));
                }
            }

            for (var i = 0; i < 11; i++)
            {
                students[i].GetAllMarks();
            }

            for (var i = 0; i < 11; i++)
            {
                double avg = 0;
                Console.WriteLine(students[i].GetAvgMark(out avg));
            }

            for (var i = 0; i < 11; i++)
            {
                students[i].ResetAllMarks();
            }

            for (var i = 0; i < 11; i++)
            {
                students[i].GetAllMarks();
            }
        }
    }
}
