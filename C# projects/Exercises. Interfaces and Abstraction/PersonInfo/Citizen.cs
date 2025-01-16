using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public class Citizen : Person, IPerson, IIdentifiable, IBirthable
    {
        public Citizen(string name, int age) : base(name, age)
        {

        }

        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Birthdate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
