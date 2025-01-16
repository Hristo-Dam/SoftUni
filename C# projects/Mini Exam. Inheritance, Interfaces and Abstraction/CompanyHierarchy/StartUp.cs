using System.Diagnostics;

namespace CompanyHierarchy
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(" ")
                .ToArray();

            List<SalesEmployee> employees = new List<SalesEmployee>();
            List<Engineer> engineers = new List<Engineer>();
            List<Junior> juniors = new List<Junior>();

            while (command[0] != "End")
            {
                if (command[2] == "Sales")
                {
                    SalesEmployee salesEmployee = new SalesEmployee(command[0], command[1], command[2], decimal.Parse(command[3]));
                    employees.Add(salesEmployee);
                    //Console.WriteLine(salesEmployee);
                    //Console.WriteLine($"Recives a salary {salesEmployee.GetSalary():F1}.");
                }
                else if (command[2] == "Engineering")
                {
                    Engineer engineer = new Engineer(command[0], command[1], command[2], int.Parse(command[3]));
                    engineers.Add(engineer);
                    //Console.WriteLine(engineer);
                    //Console.WriteLine($"Recives a salary {engineer.GetSalary()}.");
                }
                else if (command[2] == "Junior")
                {
                    Junior junior = new Junior(command[0], command[1], command[2]);
                    juniors.Add(junior);
                    //Console.WriteLine(junior);
                    //Console.WriteLine($"Recives a salary {junior.Salary}.");
                }
                command = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
            }

            foreach(SalesEmployee s in employees)
            {
                Console.WriteLine(s);
                Console.WriteLine($"Receives a salary {s.GetSalary():F1}.");
            }
            foreach(Engineer engineer in engineers)
            {
                Console.WriteLine(engineer);
                Console.WriteLine($"Receives a salary {engineer.GetSalary()}.");
            }
            foreach(Junior j in juniors)
            {
                Console.WriteLine(j);
                Console.WriteLine($"Receives a salary {j.Salary}.");
            }
        }
    }
}
