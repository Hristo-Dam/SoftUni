
int[] numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int numbersToMove = int.Parse(Console.ReadLine());


//int currentNumber = 0;

//if (numbersToMove < numbers.Length)
//{
//    for (int i = 0; i < numbersToMove; i++)
//    {
//        currentNumber = i;
//    }
//}
//else if (numbersToMove == numbers.Length)
//{
//    Console.WriteLine(string.Join(" ", numbers));
//}
//else if (numbersToMove > numbers.Length)
//{
//    numbersToMove -= numbers.Length;
//}