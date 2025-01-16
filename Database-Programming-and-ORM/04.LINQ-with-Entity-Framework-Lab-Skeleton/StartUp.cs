using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using SoftUni.Data;
using SoftUni.Data.Models;
using SoftUni.ViewModels;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();

            // 1
            //Console.WriteLine(EmployeesFirstLastName(context));

            // 2
            //Console.WriteLine(EmployeesByLastName(context));

            // 3
            //Console.WriteLine(FirstNamesOfAllEmployees(context));

            // 4
            //Console.WriteLine(AllEmployeesExceptEngineers(context));

            // 5
            //Console.WriteLine(FindTownsWithNameLength(context));

            // 6
            //Console.WriteLine(FindTownsStartingWith(context));

            // 7
            //Console.WriteLine(FindTownsNotStartingWith(context));

            // 8
            //Console.WriteLine(EmployeesHiredAfter(context));

            // 9
            //Console.WriteLine(LengthOfLastName(context));

            Console.WriteLine(EmployeeAddress(context));
        }


        // 1
        public static string EmployeesFirstLastName(SoftUniContext context)
        {
            var result = context.Employees
                .Select(e => new EmployeeFirstLastName
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                })
                .Where(e => e.FirstName.ToLower().StartsWith("sa"))
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in result)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName}"); 
            }

            return sb.ToString().Trim();
        }

        // 2
        public static string EmployeesByLastName(SoftUniContext context)
        {
            var result = context.Employees
                .Select(e => new EmployeesByLastName
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName
                })
                .Where(e => e.LastName.ToLower().Contains("ei"))
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in result)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName}");
            }

            return sb.ToString().Trim();
        }

        // 3
        public static string FirstNamesOfAllEmployees(SoftUniContext context)
        {
            var result = context.Employees
                .Select(e => new FirstNamesOfAllEmployees
                {
                    FirstName = e.FirstName,
                    DepartmentId = e.DepartmentId,
                    HireDate = e.HireDate,
                })
                .Where(e => (e.DepartmentId == 3 || e.DepartmentId == 10) &&  
                (e.HireDate.Year > 1995 && e.HireDate.Year < 2000))
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in result)
            {
                sb.AppendLine($"{employee.FirstName}");
            }

            return sb.ToString().Trim();
        }

        // 4
        public static string AllEmployeesExceptEngineers(SoftUniContext context)
        {
            var result = context.Employees
                .Select(e => new AllEmployeesExceptEngineers
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    JobTitle = e.JobTitle
                })
                .Where(e => !(e.JobTitle.ToLower().Contains("engineer")))
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in result)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName}");
            }

            return sb.ToString().Trim();
        }

        // 5
        public static string FindTownsWithNameLength(SoftUniContext context)
        {
            var result = context.Towns
                .Select(t => new FindTownsWithNameLength
                {
                    Name = t.Name
                })
                .Where(t => t.Name.Length == 5 ||  t.Name.Length == 6)
                .OrderBy(t => t.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var town in result)
            {
                sb.AppendLine($"{town.Name}");
            }

            return sb.ToString().Trim();
        }

        // 6
        public static string FindTownsStartingWith(SoftUniContext context)
        {
            var result = context.Towns
                .Select(t => new FindTownsStartingWith
                {
                    Id = t.TownId,
                    Name = t.Name
                })
                .Where(t => (
                    t.Name.ToUpper().StartsWith("M") ||
                    t.Name.ToUpper().StartsWith("K") ||
                    t.Name.ToUpper().StartsWith("B") ||
                    t.Name.ToUpper().StartsWith("E"))
                )
                .OrderBy(t => t.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var town in result)
            {
                sb.AppendLine($"{town.Id} - {town.Name}");
            }

            return sb.ToString().Trim();
        }

        // 7
        public static string FindTownsNotStartingWith(SoftUniContext context)
        {
            var result = context.Towns
                .Select(t => new FindTownsStartingWith
                {
                    Id = t.TownId,
                    Name = t.Name
                })
                .Where(t => !(
                    t.Name.ToUpper().StartsWith("R") ||
                    t.Name.ToUpper().StartsWith("B") ||
                    t.Name.ToUpper().StartsWith("D"))
                )
                .OrderBy(t => t.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var town in result)
            {
                sb.AppendLine($"{town.Id} - {town.Name}");
            }

            return sb.ToString().Trim();
        }

        // 8
        public static string EmployeesHiredAfter(SoftUniContext context)
        {
            var result = context.Employees
                .Select(e => new EmployeesHiredAfter
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    HireDate = e.HireDate
                })
                .Where(e => e.HireDate.Year > 2000)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in result)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.LastName}");
            }

            return sb.ToString().Trim();
        }

        // 9
        public static string LengthOfLastName(SoftUniContext context)
        {
            var result = context.Employees
                .Select(e => new LengthOfLastName
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName
                })
                .Where(e => e.LastName.Length == 5)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in result)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.LastName}");
            }

            return sb.ToString().Trim();
        }

        public static string EmployeeAddress(SoftUniContext context)
        {
            var result = context.Employees
                .Select(e => new EmployeeAddress
                {
                    EmployeeId = e.EmployeeId,
                    JobTitle = e.JobTitle,
                    AddressId = e.AddressId,
                    AddressText = e.Address.AddressText
                })
                .OrderBy(e => e.AddressId)
                .Take(5)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var employee in result)
            {
                sb.AppendLine($"{employee.EmployeeId} - {employee.JobTitle} {employee.AddressId} - {employee.AddressText}");
            }

            return sb.ToString().Trim();
        }
    }
}
