int balance = 1000;

Console.WriteLine("Hello!");
Console.WriteLine("You can check your BALANCE");
Console.WriteLine("You can make a WITHDRAW");
Console.WriteLine("You can put in a DEPOSIT");
Console.WriteLine("You can try to win money by playing BLACKJACK in the casino!");

while (true)
{
    string currentWord = Console.ReadLine();
    if (currentWord == "WITHDRAW")
    {
        Console.WriteLine("Withdraw amount?");
        int withdrawAmount = int.Parse(Console.ReadLine());

        if (withdrawAmount <= balance)
        {
            balance -= withdrawAmount;
            Console.WriteLine($"Your new balance is {balance}");
        }
        else if (withdrawAmount > balance)
        {
            Console.WriteLine("You don't have enough money in the bank!");
            Console.WriteLine($"Your banalce is {balance}");
        }
    }
    else if (currentWord == "DEPOSIT")
    {
        Console.WriteLine("Deposit amount?");
        int depositAmount = int.Parse(Console.ReadLine());
        balance += depositAmount;
        Console.WriteLine($"Your new balance is {balance}");
    }
    else if (currentWord == "BALANCE")
    {
        Console.WriteLine($"Your balance is {balance}");
    }
    else if (currentWord == "BLACKJACK")
    {
        Console.WriteLine("Type START GAME to begine");
        Console.WriteLine("Type STOP GAME to end the game");
        string blackjackComands = Console.ReadLine();
        if (blackjackComands == "START GAME")
        {
            bool blackjackGame = true;
            while (blackjackGame == true)
            {
                int playerHand = 0;
                Random rnd = new Random();

                int pCard1 = rnd.Next(1, 12);
                Console.WriteLine($"Your 1st card is: {pCard1}");
                playerHand += pCard1;
                Console.WriteLine($"Your hand is: {playerHand}");

                int dealerHand = 0;

                int dCard1 = rnd.Next(1, 12);
                Console.WriteLine($"Dealer's 1st card is: {dCard1}");
                dealerHand += dCard1;
                Console.WriteLine($"Dealer's hand is: {dealerHand}");

                int pCard2 = rnd.Next(1, 12);
                Console.WriteLine($"You 2nd card is: {pCard2}");
                playerHand += pCard2;
                Console.WriteLine($"Your hand is: {playerHand}");

                if (playerHand == 21)
                {
                    Console.WriteLine("LUCKY! YOU HAVE A BLACKJACK!");
                }
                else if (playerHand > 21)
                {
                    Console.WriteLine("Sorry! You got a bust!");
                }

                int count = 0;
                bool stand = false;

                while (stand == false && count < 20 && playerHand < 21)
                {
                    Console.WriteLine("HIT or STAND?");
                    string hitOrStand = Console.ReadLine();

                    if (hitOrStand == "HIT")
                    {
                        int pCard3 = rnd.Next(1, 12);
                        Console.WriteLine($"You card is: {pCard3}");
                        playerHand += pCard3;
                        Console.WriteLine($"Your hand is: {playerHand}");

                        if (playerHand == 21)
                        {
                            Console.WriteLine("LUCKY! YOU HAVE A BLACKJACK!");
                        }
                        else if (playerHand > 21)
                        {
                            Console.WriteLine("Sorry! You got a bust!");
                        }
                        else if (playerHand < 21)
                        {

                        }
                    }
                    else if (hitOrStand == "STAND")
                    {
                        stand = true;

                        int dCard2 = rnd.Next(1, 12);
                        Console.WriteLine($"Dealer's 2nd card is: {dCard2}");
                        dealerHand += dCard2;
                        Console.WriteLine($"Dealer's hand is: {dealerHand}");
                    }
                }
            }
        }
    }
    else if (currentWord == "END")
    {
        break;
    }
}