using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Employee_Statistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            double highestSalary = 0;
            string department = "";
            
            for (int i = 0; i < n; i++)
            {
                List<string> list = Console.ReadLine()
                .Split()
                .ToList();
                Employee employee = new Employee();
                employee.Name = list[0];
                employee.Salary = double.Parse(list[1]);
                employee.Department = list[2];
                employees.Add(employee);
            }

            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Salary > highestSalary)
                {
                    highestSalary = employees[i].Salary;
                    department = employees[i].Department;
                }
            }

            List<Employee> sortedList = employees.OrderByDescending(x => x.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {department}");

            for (int h = 0; h < sortedList.Count; h++)
            {
                if (sortedList[h].Department == department)
                {
                    Console.WriteLine($"{sortedList[h].Name} {sortedList[h].Salary:F2}");
                }
            }
        }
    }

    public class Employee
    {
        public string Name;
        public double Salary;
        public string Department;
    }
}