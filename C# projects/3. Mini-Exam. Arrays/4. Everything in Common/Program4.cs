int[] firstArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] secondArray = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

bool matched = true;
int indexDifference = 0;

if (firstArray.Length != secondArray.Length)
{
    matched = false;
}
else
{
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i] != secondArray[i])
        {
            matched = false;
            indexDifference = i;
            break;
        }
    }
}

if (matched)
{
    Console.WriteLine("Arrays are identical.");
    Console.WriteLine($"Sum: {firstArray.Sum()}");
}
else
{
    Console.WriteLine("Arrays are not identical.");
    Console.WriteLine($"Found difference at {indexDifference} index");
}