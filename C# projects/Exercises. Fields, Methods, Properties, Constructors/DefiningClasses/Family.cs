using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldestPerson = new Person();

            oldestPerson = members.OrderByDescending(person => person.Age).First();

            return oldestPerson;
        }

        public void OpinionPoll()
        {
            members = members.Where(person => person.Age > 30).OrderBy(person => person.Name).ToList();
            foreach (Person person in members)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }

        public List<Person> GetMembers()
        {
            return members;
        }
    }
}
