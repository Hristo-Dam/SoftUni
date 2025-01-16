int numberOfStudents = int.Parse(Console.ReadLine());

string[] namesOfStudents = new string[numberOfStudents];

for (int i = 0; i < numberOfStudents; i++)
{
    namesOfStudents[i] = Console.ReadLine();
}

Console.WriteLine(string.Join(", ", namesOfStudents)); 