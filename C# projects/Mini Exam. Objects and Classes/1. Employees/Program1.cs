using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                List<string> list = Console.ReadLine()
                .Split()
                .ToList();
                Employee employee = new Employee();
                employee.FirstName = list[0];
                employee.LastName = list[1];
                employee.Salary = float.Parse(list[2]);
                employees.Add(employee);
            }

            List<Employee> sortedList = employees.OrderByDescending(x => x.Salary).ToList();

            for (int h = 0; h < sortedList.Count; h++)
            {
                Console.WriteLine($"{sortedList[h].FirstName} {sortedList[h].LastName}: {sortedList[h].Salary:F2}");
            }
        }
    }

    public class Employee
    {
        public string FirstName;
        public string LastName;
        public float Salary;
    }
}
