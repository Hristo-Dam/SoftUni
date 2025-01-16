double[] numbers = Console.ReadLine()
    .Split(' ')
    .Select(double.Parse)
    .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] /= 2;
}

Console.Write(string.Join(" ", numbers));