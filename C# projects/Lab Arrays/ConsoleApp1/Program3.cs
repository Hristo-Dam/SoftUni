string input = Console.ReadLine();

double[] numbers = input
    .Split()
    .Select(double.Parse)
    .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        Console.WriteLine(Math.Floor(numbers[i]));
    }
    else if (numbers[i] > 0)
    {
        Console.WriteLine(Math.Ceiling(numbers[i]));
    }
}