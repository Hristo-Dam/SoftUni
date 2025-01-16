using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarchy
{
    public class Junior : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }

        public Junior(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Salary = 900;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Department} engineer.";
        }
    }
}
