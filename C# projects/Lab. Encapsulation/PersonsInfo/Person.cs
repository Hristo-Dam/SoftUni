using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private decimal _salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName
        {
            get { return this._firstName; }
            private set 
            { 
                if (value.Length >= 3)
                {
                    this._firstName = value;
                }
                else
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public string LastName
        {
            get { return this._lastName; }
            private set
            {
                if (value.Length >= 3)
                {
                    this._lastName = value;
                }
                else
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
            }
        }
        public int Age
        {
            get { return this._age; }
            private set
            {
                if (value > 0)
                {
                    this._age = value;
                }
                else
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
            }
        }
        public decimal Salary
        {
            get { return this._salary; }
            private set
            {
                if (value >= 460)
                {
                    this._salary = value;
                }
                else
                {
                    throw new ArgumentException("Salary cannot be less than 460 leva!");
                }
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age >= 30)
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
