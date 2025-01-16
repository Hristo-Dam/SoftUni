using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class Team
    {
        private string _name;
        private List<Person> _firstTeam;
        private List<Person> _reserveTeam;

        public Team(string name)
        {
            this._name = name;
            this._firstTeam = new List<Person>();
            this._reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this._firstTeam.AsReadOnly(); }
        }
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this._reserveTeam.AsReadOnly(); }
        }

        public void Add(Person person)
        {
            if (person.Age < 40)
            {
                this._firstTeam.Add(person);
            }
            else
            {
                this._reserveTeam.Add(person);
            }
        }
    }
}
