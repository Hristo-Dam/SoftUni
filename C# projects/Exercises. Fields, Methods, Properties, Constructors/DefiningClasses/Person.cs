using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person()
        {
            Name = "No name";
            Age = 1;
        }

        public Person(int age) : this()
        {
            this.Age = age;
        }

        public Person(int age, string name) : this(age)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }
    }
}
