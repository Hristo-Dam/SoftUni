using Microsoft.EntityFrameworkCore;
using SoftUni.Data;
using System;
using System.Linq;
using System.Text;
using System.Web;

namespace SoftUni
{
    public class StartUp
    {
        static void Main()
        {
            var context = new SoftUniContext();
            int employeeId = 1;
            int projectId = 1;
        }
        public static string AddEmployeeToProject(SoftUniContext context, int employeeId, int projectId)
        {
            context.Database
                .ExecuteSqlInterpolated($"EXEC sp_AddEmployeeToProject {employeeId}, {projectId}");

            var result = context.Employees
                .Where(e => e.EmployeeId == employeeId)
                .Select(e => new
                {
                    e.EmployeeId,
                    Projects = e.EmployeesProjects
                        .OrderBy(x => x.ProjectId)
                        .ToArray()
                        .Take(3)
                });

            return string.Join(Environment.NewLine, result
                .Select(x =>
                $"Employee Id:{x.EmployeeId}, Projects:" +
                $"{Environment.NewLine}" +
                $"{string.Join(Environment.NewLine, x.Projects.Select(x => x.ProjectId))}"
            ));
        }
        //public static string DeleteRecordsWithProjectId(SoftUniContext context, int projectId)
        //{

        //}

    }
}
