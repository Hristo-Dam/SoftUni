using System;
using System.Linq;
using System.Collections.Generic;

namespace Tik_Tak_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameLoop();
        }

        static void Draw(char[,] board)
        {
            Console.Clear();
            Console.WriteLine($"    A   B   C  ");
            Console.WriteLine($"  -------------");
            Console.WriteLine($"1 | {board[0, 0]} | {board[0, 1]} | {board[0, 2]} |");
            Console.WriteLine($"  -------------");
            Console.WriteLine($"2 | {board[1, 0]} | {board[1, 1]} | {board[1, 2]} |");
            Console.WriteLine($"  -------------");
            Console.WriteLine($"3 | {board[2, 0]} | {board[2, 1]} | {board[2, 2]} |");
            Console.WriteLine($"  -------------");
        }

        static void GameLoop()
        {
            char[,] board =
{
                {' ', ' ', ' ' },
                {' ', ' ', ' ' },
                {' ', ' ', ' ' }
            };

            Draw(board);

            while (true)
            {

                string input = Console.ReadLine();
                if (input == "END")
                {
                    return;
                }

                int y = int.Parse("" + input[1]) - 1;
                int x;

                switch (input[0])
                {
                    case 'A':
                        x = 0;
                        break;
                    case 'B':
                        x = 1;
                        break;
                    case 'C':
                        x = 2;
                        break;
                    default:
                        x = -1;
                        break;
                }

                int[] result = new int[2];
                result[0] = x;
                result[1] = y;

                Draw(board);

                char playerTurn = 'X';
                int winner = 0;

                board[x, y] = playerTurn;

                if (playerTurn == 'X')
                {

                }
            }


        }

        static char CheckWinCondition(char[,] board)
        {
            char[] players = { 'X', 'O' };
            foreach (char p in players)
            {

                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == p && board[i, 1] == p && board[i, 2] == p)
                    {
                        return p;
                    }
                    if (board[0, i] == p && board[1, i] == p && board[2, i] == p)
                    {
                        return p;
                    }
                }

                if ((board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X')
                    || (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X'))
                {
                    return p;
                }

                return ' ';
            }

        }
        static void EndGame(char winner)
        {

        }
    }
}
