using System;
using System.Linq;
using System.Collections.Generic;

namespace _1._Bowling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerOneScore = 0;
            int playerTwoScore = 0;

            int playerOneTurn = 0;
            int playerTwoTurn = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    playerOneTurn = int.Parse(Console.ReadLine());
                    playerOneScore += playerOneTurn;
                }

                for (int k = 0;k < 2; k++)
                {
                    playerTwoTurn = int.Parse(Console.ReadLine());
                    playerTwoScore += playerTwoTurn;
                }
            }

            bool playerOneHitTen = false;
            bool playerTwoHitTen = false;

            playerOneTurn = int.Parse(Console.ReadLine());
            if (playerOneTurn == 10)
            {
                playerOneScore += playerOneTurn;
                playerOneTurn = int.Parse(Console.ReadLine());
                playerOneScore += playerOneTurn;

                playerOneHitTen = true;
            }

            playerOneTurn = int.Parse(Console.ReadLine());
            if (playerOneHitTen == false)
            {
                if (playerOneTurn == 10)
                {
                    playerOneScore += playerOneTurn;
                    playerOneTurn = int.Parse(Console.ReadLine());
                    playerOneScore += playerOneTurn;
                }
            }
            else
            {
                playerOneScore += playerOneTurn;
            }


            playerTwoTurn = int.Parse(Console.ReadLine());
            if (playerTwoTurn == 10)
            {
                playerTwoScore += playerTwoTurn;
                playerTwoTurn = int.Parse(Console.ReadLine());
                playerTwoScore += playerTwoTurn;

                playerTwoHitTen = true;
            }

            playerTwoTurn = int.Parse(Console.ReadLine());
            if (playerTwoHitTen == false)
            {
                if (playerTwoTurn == 10)
                {
                    playerTwoScore += playerTwoTurn;
                    playerTwoTurn = int.Parse(Console.ReadLine());
                    playerTwoScore += playerTwoTurn;
                }
            }
            else
            {
                playerTwoScore += playerTwoTurn;
            }

            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("Congratulations! Player One is the winner!");
            }
            else if (playerOneScore == playerTwoScore)
            {
                Console.WriteLine("The result of the game is equel.");
            }
            else
            {
                Console.WriteLine("Congratulations! Player Two is the winner!");
            }
        }
    }
}
