int numberOfRows = int.Parse(Console.ReadLine());

int[] arrayOne = new int[numberOfRows];

int[] arrayTwo = new int[numberOfRows];

for (int i = 0; i < numberOfRows; i++)
{
    int[] bigArray = Console.ReadLine()
        .Split(" ")
        .Select(int.Parse)
        .ToArray();
    if (i % 2 == 0)
    {
        arrayOne[i] = bigArray[0];
        arrayTwo[i] = bigArray[1];
    }
    else if (i % 2 == 1)
    {
        arrayOne[i] = bigArray[1];
        arrayTwo[i] = bigArray[0];
    }
}
Console.WriteLine(String.Join(" ", arrayOne));
Console.WriteLine(String.Join(" ", arrayTwo));