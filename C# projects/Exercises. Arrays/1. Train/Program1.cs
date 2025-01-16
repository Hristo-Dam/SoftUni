int howMany = int.Parse(Console.ReadLine());

int[] numbers = new int[howMany];

int sum = 0;

for (int i = 0; i < howMany; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
    sum += numbers[i];
}
Console.WriteLine(string.Join(" ", numbers));
Console.WriteLine(sum);