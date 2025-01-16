decimal britishPound = decimal.Parse(Console.ReadLine());
decimal usDolar = britishPound * 1.31M;
Console.WriteLine($"{usDolar:F3}");