int n = int.Parse(Console.ReadLine());

string[] names = new string[n];

for (int i = 0; i < n; i++)
{
    names[i] = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", names));