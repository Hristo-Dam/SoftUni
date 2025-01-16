string[] seasons = { "Spring", "Summer", "Autumn", "Winter" };

int num = int.Parse(Console.ReadLine());

if (num < 1 || num > 4)
{
    Console.WriteLine("Invalid index!");
}
else
{
    Console.WriteLine(seasons[num - 1]);
}