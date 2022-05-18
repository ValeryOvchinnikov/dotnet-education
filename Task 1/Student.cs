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

        public double GetAvgMark()
        {
            return this.Marks.Average(m => m.Value);
        }

        public void ResetAllMarks()
        {
            foreach (Mark mark in Marks)
            {
                mark.Value = 0;
            }
        }
    }
}
