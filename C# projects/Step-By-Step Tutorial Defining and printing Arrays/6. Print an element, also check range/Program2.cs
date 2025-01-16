string[] seasons = { "Spring", "Summer", "Autumn", "Winter" };

int num = int.Parse(Console.ReadLine());

if (num < 0 || num > 3)
{
    Console.WriteLine("Invalid index!");
}
else
{
    Console.WriteLine(seasons[num]);
}   