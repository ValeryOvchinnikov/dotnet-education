using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Employee : IComparable<Employee>
    {
        public string PersonalInfo { get; set; }
        public double Salary { get; set; }

        public static List<Employee> SortBySalary(List<Employee> employees)
        {
            return employees.OrderBy(p => p.Salary).ToList();
        }
       
        public int CompareTo(Employee employee)
        {
            if (employee == null)
                return 1;

            else
                return this.PersonalInfo.CompareTo(employee.PersonalInfo);
        }

        public override string ToString()
        {
            return "Personal information" + PersonalInfo + " Salary - " + Salary;
        }
    }
}
