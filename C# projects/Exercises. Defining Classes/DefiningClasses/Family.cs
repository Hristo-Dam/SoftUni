using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> listOfPeople = new List<Person>();

        public void Add(Person member)
        {
            listOfPeople.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestMember = listOfPeople.OrderByDescending(x => x.Age).First();

            return oldestMember;
        }

        public List<Person> GetOlderMembers()
        {
            List<Person> result = listOfPeople
                .Where(x => x.Age > 30)
                .OrderBy(x => x.Name)
                .ToList();

            return result;
        }
    }
}
