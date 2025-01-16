using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private decimal _salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._age = age;
            this._salary = salary;
        }

        public string FirstName
        {
            get { return this._firstName; }
            set { this._lastName = value; }
        }
        public string LastName
        {
            get { return this._lastName; }
            set { this._firstName = value; }
        }
        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }
        public decimal Salary
        {
            get { return this._salary; }
            set { this._salary = value; }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }
    }
}
