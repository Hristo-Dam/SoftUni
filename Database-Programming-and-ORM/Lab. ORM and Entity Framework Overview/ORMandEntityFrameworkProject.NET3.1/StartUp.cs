using ORMandEntityFrameworkProject.NET3._1.Data;
using ORMandEntityFrameworkProject.NET3._1.Models;
using System;
using System.Linq;

namespace ORMandEntityFrameworkProject.NET3._1
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            // 1. Find Employees with Job Title
            var context = new SoftUniContext();
            var result = FindEmployeesWithJobTitle(context);
            Console.WriteLine(result);

            // 2. Find Project with ID
            //var context = new SoftUniContext();
            //var result = FindProjectWithId(context);
            //Console.WriteLine(result);

            // 3. Create New Project
            //var context = new SoftUniContext();
            //CreateNewProject(context);

            // 4. Update First Employee
            //var context = new SoftUniContext();
            //var result = UpdateFirstEmployee(context);
            //Console.WriteLine(result);

            // 5. Delete First Project
            //var context = new SoftUniContext();
            //var result = DeleteFirstProject(context);
            //Console.WriteLine(result);

            // 6. Update Addresses
            //var context = new SoftUniContext();
            //var result = UpdateAddresses(context);
            //Console.WriteLine(result);
        }

        // 1. Find Employees with Job Title
        public static string FindEmployeesWithJobTitle(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.JobTitle == "Design Engineer")
                .Select(x => x.FirstName)
                .ToList();

            return string.Join(Environment.NewLine, employees);
        }

        // 2. Find Project with ID
        public static string FindProjectWithId(SoftUniContext context)
        {
            var project = context.Projects.Find(2);
            return project.Name;
        }

        // 3. Create New Project
        public static void CreateNewProject(SoftUniContext context)
        {
            var project = new Projects()
            {
                Name = "Our Newest Project",
                StartDate = new DateTime(2021, 1, 1)
            };

            context.Projects.Add(project);
            context.SaveChanges();
        }

        // 4. Update First Employee
        public static string UpdateFirstEmployee(SoftUniContext context)
        {
            Employees employee = context.Employees.FirstOrDefault();
            if (employee != null)
            {
                employee.FirstName = "Alex";
                context.SaveChanges();
                return employee.FirstName;
            }
            return "";
        }

        // 5. Delete First Project
        public static string DeleteFirstProject(SoftUniContext context)
        {
            Projects project = context.Projects.FirstOrDefault();
            context.Projects.Remove(project);
            context.SaveChanges();
            return project.Name;
        }

        // 6. Update Addresses
        public static string UpdateAddresses(SoftUniContext context)
        {
            var addresses = context.Addresses
                .Where(a => a.AddressText.Contains("Drive"))
                .Select(a => a.TownId)
                .ToList();

            return addresses.Count.ToString();
        }
    }
}