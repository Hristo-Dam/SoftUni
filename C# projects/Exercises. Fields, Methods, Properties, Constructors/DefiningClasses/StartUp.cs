using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] currentPerson = Console.ReadLine()
                    .Split()
                    .ToArray();

                Person person = new Person();
                
                person.Name = currentPerson[0];
                person.Age = int.Parse(currentPerson[1]);

                family.AddMember(person);
            }

            //mily.OpinionPoll();

            //Person oldestMember = family.GetOldestMember();
            //Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
        }
    }
}
