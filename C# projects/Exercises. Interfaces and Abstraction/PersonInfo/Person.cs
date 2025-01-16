using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class Person
    {
        private string _name;
        private int _age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
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
