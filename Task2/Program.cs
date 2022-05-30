using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Employee> list = new List<Employee>();

            for (int i = 0; i < 5; i++)
            {
                Employee employee = new Employee();
                employee.PersonalInfo = "information" + random.Next(1, 100);
                employee.Salary = random.Next(500, 1100);
                list.Add(employee);
            }

            Console.WriteLine("Original");
            foreach (Employee item in list)
                Console.WriteLine(item.ToString());

            Console.WriteLine("Sort by salary");
            list = Employee.SortBySalary(list);
            foreach (Employee item in list)
                Console.WriteLine(item.ToString());

            Console.WriteLine("Sort by information");
            list.Sort();
            foreach (Employee item in list)
                Console.WriteLine(item.ToString());
        }
    }
}
