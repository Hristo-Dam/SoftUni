int n = int.Parse(Console.ReadLine());

int[] names = new int[n];

for (int i = 0; i < n; i++)
{
    names[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine(string.Join(" ", names));