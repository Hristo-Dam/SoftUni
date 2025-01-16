namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0;  i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ');
                Person person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                people.Add(person);
            }

            //decimal percentage = decimal.Parse(Console.ReadLine());

            //people.OrderBy(p => p.FirstName)
            //    .ThenBy(p => p.Age)
            //    .ToList();

            //foreach (Person person in people)
            //{
            //    person.IncreaseSalary(percentage);
            //}
            //foreach (Person person in people)
            //{
            //    Console.WriteLine(person.ToString());
            //}

            Team team = new Team("SoftUni");
            foreach (Person person in people)
            {
                team.Add(person);
            }
        }
    }
}
