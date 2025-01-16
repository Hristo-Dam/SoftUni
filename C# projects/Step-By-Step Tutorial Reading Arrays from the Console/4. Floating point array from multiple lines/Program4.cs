int n = int.Parse(Console.ReadLine());

float[] names = new float[n];

for (int i = 0; i < n; i++)
{
    names[i] = float.Parse(Console.ReadLine());
}

Console.WriteLine(string.Join(" ", names));