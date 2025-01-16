int[] numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] += 10;
}

Console.Write(string.Join(" ", numbers));