int num = int.Parse(Console.ReadLine());
int sum = 0;

while (num > 0)
{
    int digit = num % 10;
    sum += digit;

    num /= 10;
}

Console.WriteLine(sum);