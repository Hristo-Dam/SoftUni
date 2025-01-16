int[] givenNumbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int specialNumber = int.Parse(Console.ReadLine());

for (int i = 0; i < givenNumbers.Length; i++)
{
    for (int k = i + 1; k < givenNumbers.Length; k++)
    {
        if (givenNumbers[i] + givenNumbers[k] == specialNumber)
        {
            Console.WriteLine($"{givenNumbers[i]} {givenNumbers[k]}");
        }
    }
}