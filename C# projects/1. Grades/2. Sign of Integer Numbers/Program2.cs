using System;

static void Main(string[] args)
{
    int num = int.Parse(Console.ReadLine());
    PositiveOrNegative(num);
}

static void PositiveOrNegative(int number)
{
    if (number < 0)
    {
        Console.WriteLine($"The number {number} is negative.");
    }
    else if (number == 0)
    {
        Console.WriteLine($"The number {number} is zero.");
    }
    else if (number > 0)
    {
        Console.WriteLine($"The number {number} is positive.");
    }
}

