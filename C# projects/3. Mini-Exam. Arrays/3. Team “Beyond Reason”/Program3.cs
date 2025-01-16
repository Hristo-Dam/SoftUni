string[] namesOfStudents = Console.ReadLine().Split(", ");
string nameToSearch = Console.ReadLine();

bool nameIsInTheTeam = true;

for (int i = 0; i < namesOfStudents.Length; i++)
{
    if (nameToSearch == namesOfStudents[i])
    {
        nameIsInTheTeam = true;
        break;
    }
    else
    {
        nameIsInTheTeam = false;
    }
}

if (nameIsInTheTeam)
{
    Console.WriteLine($"{nameToSearch} is in Team Beyond Reason.");
}
else
{
    Console.WriteLine($"{nameToSearch} is not in Team Beyond Reason.");
}