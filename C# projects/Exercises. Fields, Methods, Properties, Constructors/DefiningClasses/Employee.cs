using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Employee
    {
        private string _name;
        private decimal _salary;
        private string _position;
        private string _department;
        private string _email;
        private int _age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
        }
        public Employee(string name, decimal salary, string position, string department, string email)
            : this(name, salary, position, department)
        {
            this.Email = email;
        }
        public Employee(string name, decimal salary, string position, string department, int age)
            : this(name, salary, position, department)
        {
            this.Age = age;
        }
        public Employee(string name, decimal salary, string position, string department, string email, int age)
            : this(name, salary, position, department, email)
        {
            this.Age = age;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public decimal Salary
        {
            get { return this._salary; }
            set { this._salary = value; }
        }
        public string Position
        {
            get { return this._position; }
            set { this._position = value; }
        }
        public string Department
        {
            get { return this._department; }
            set { this._department = value; }
        }
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }
    }
}
