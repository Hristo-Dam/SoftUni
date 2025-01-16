namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            string[] personInput = new string[2];

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                personInput = Console.ReadLine()
                    .Split()
                    .ToArray();

                Person person = new Person();
                person.Name = personInput[0];
                person.Age = int.Parse(personInput[1]);

                family.Add(person);
            }

            List<Person> personList = family.GetOlderMembers();

            foreach (Person person in personList)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

            //Person oldestPerson = family.GetOldestMember();
            //Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}