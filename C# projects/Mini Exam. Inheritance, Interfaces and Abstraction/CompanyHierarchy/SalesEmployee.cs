using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class SalesEmployee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public decimal Profits {  get; set; }

        public SalesEmployee (string firstName, string lastName, string department, decimal profits)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Salary = 1000;
            Profits = profits;
        }

        public decimal GetSalary()
        {
            decimal result = (Profits / 100 * 10) + Salary;
            return result;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} from {this.Department} has {Profits} profits.";
        }
    }
}
