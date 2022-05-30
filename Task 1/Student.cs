using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Student
    {
        Mark[] marks;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Mark[] Marks
        {
            get { return marks; }
            set { marks = value; }

        }


        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, Mark[] marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Marks = marks;
        }

        public double GetAvgMark(out double avg)
        {
            double a = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                a = a + Marks[i].Value;
            }
            return avg = a / Marks.Length;
        }

        public void GetAllMarks()
        {
            foreach (Mark mark in this.Marks)
            {
                Console.WriteLine($"{this.FirstName} {this.LastName}-{mark.SubjectName} --- {mark.Value}\r\n");
            }
            Console.WriteLine("\r\n");
        }

        public void ResetAllMarks()
        {
            foreach (Mark mark in this.Marks)
            {
                mark.Value = 0;
            }
        }
    }
}
