namespace GolfAndSpaResort
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                .Split(" ")
                .ToArray();

            int rowCount = 0;
            string freeAccess = "";

            while (command[0] != "End")
            {
                rowCount++;
                if(command.Length == 2)
                {
                    Guest guest = new Guest(command[0], command[1]);
                    Console.WriteLine(guest.NewGuest());
                }
                else if(command.Length == 3)
                {
                    Member member = new Member(command[0], command[1], int.Parse(command[2]));
                    if(rowCount % 2 == 0)
                    {
                        freeAccess = "fitness";
                    }
                    else
                    {
                        freeAccess = "spa";
                    }
                    Console.WriteLine(member.GetMembershipId(freeAccess));
                }
                else if( command.Length == 4)
                {
                    Employee emploee = new Employee(command[0], command[1], command[2], int.Parse(command[3]));
                    Console.WriteLine(emploee.StartWorkingDay());
                }

                command = Console.ReadLine()
                    .Split(" ")
                    .ToArray();
            }
        }
    }
}
