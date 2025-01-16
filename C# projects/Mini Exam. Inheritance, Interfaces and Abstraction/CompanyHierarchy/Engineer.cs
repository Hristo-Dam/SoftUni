using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Engineer : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public int YearsService { get; set; }

        public Engineer(string firstName, string lastName, string department, int yearsService)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Salary = 1300;
            YearsService = yearsService;
        }

        public decimal GetSalary()
        {
            decimal result = Salary + (90 * YearsService);
            return result;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} from {Department} has {YearsService} years of service.";
        }
    }
}
