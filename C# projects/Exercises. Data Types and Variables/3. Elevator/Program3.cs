int people = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());

int courses = 0;
courses = people / capacity;

if (people % capacity != 0)
{
    courses += 1;
}

Console.WriteLine(courses);