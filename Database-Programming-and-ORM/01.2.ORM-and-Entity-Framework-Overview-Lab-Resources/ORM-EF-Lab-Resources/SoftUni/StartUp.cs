using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Linq;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            // 1. Find Employees with Job Title
            //var context = new SoftUniContext();
            //var result = FindEmployeesWithJobTitle(context);
            //Console.WriteLine(result);

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

        //Problem 01
        public static string FindEmployeesWithJobTitle(SoftUniContext context)
        {
            var employees = context.Employees
                .Where(e => e.JobTitle == "Design Engineer")
                .Select(x => x.FirstName)
                .ToList();
            return string.Join(Environment.NewLine, employees);
        }

        //Problem 02
        public static string FindProjectWithId(SoftUniContext context)
        {
            var project = context.Projects.Find(2);
            return project.Name;
        }

        ////Problem 03
        public static void CreateNewProject(SoftUniContext context)
        {
            var project = new Project()
            {
                Name = "Our Newest Project",
                StartDate = new DateTime(2021, 1, 1)
            };

            context.Projects.Add(project);
            context.SaveChanges();
        }

        //Problem 04
        public static string UpdateFirstEmployee(SoftUniContext context)
        {
            Employee employee = context.Employees.FirstOrDefault();
            if (employee != null)
            {
                employee.FirstName = "Alex";
                context.SaveChanges();
                return employee.FirstName;
            }
            return "";
        }

        //Problem 05
        public static string DeleteFirstProject(SoftUniContext context)
        {
            Project project = context.Projects.FirstOrDefault();
            context.Projects.Remove(project);
            context.SaveChanges();
            return project.Name;
        }

        //Problem 06
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
