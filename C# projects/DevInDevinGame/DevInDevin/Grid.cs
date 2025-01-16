using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevInDevin
{
    internal class Grid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the grid (X Y):");
            int[] sizeInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (sizeInput[0] > 20 || sizeInput[1] > 20)
            {
                Console.WriteLine("Your board is too big! The max size is 20x20");
                sizeInput = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int gridSizeX = sizeInput[0];
            int gridSizeY = sizeInput[1];

            int[,] grid = new int[gridSizeY, gridSizeX];

            // Generate random numbers for each cell in the grid
            Random random = new Random();
            for (int i = 0; i < gridSizeY; i++)
            {
                for (int j = 0; j < gridSizeX; j++)
                {
                    grid[i, j] = random.Next(1, 10);
                }
            }

            int player1X = 0;
            int player1Y = 0;

            int player2X = gridSizeX - 1;
            int player2Y = gridSizeY - 1;

            bool isPlayer1Turn = true;

            while (true)
            {
                Console.Clear();
                PrintGrid(grid, gridSizeX, gridSizeY, player1X, player1Y, player2X, player2Y);

                int currentPlayerX = isPlayer1Turn ? player1X : player2X;
                int currentPlayerY = isPlayer1Turn ? player1Y : player2Y;

                GetPlayerPosition(player1X, player1Y, isPlayer1Turn);

                Console.WriteLine($"Player {(isPlayer1Turn ? 1 : 2)}, enter your move (w - up, s - down, a - left, d - right):");
                char move = Console.ReadKey().KeyChar;

                if (move == 'w')
                {
                    if (currentPlayerY > 0)
                    {
                        if (isPlayer1Turn)
                        {
                            player1Y--;
                        }
                        else
                        {
                            player2Y--;
                        }
                    }
                }
                else if (move == 's')
                {
                    if (currentPlayerY < gridSizeY - 1)
                    {
                        if (isPlayer1Turn)
                        {
                            player1Y++;
                        }
                        else
                        {
                            player2Y++;
                        }
                    }
                }
                else if (move == 'a')
                {
                    if (currentPlayerX > 0)
                    {
                        if (isPlayer1Turn)
                        {
                            player1X--;

                        }
                        else
                        {
                            player2X--;
                        }
                    }
                }
                else if (move == 'd')
                {
                    if (currentPlayerX < gridSizeX - 1)
                    {
                        if (isPlayer1Turn)
                        {
                            player1X++;

                        }
                        else
                        {
                            player2X++;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move! Try again.");
                }

                isPlayer1Turn = !isPlayer1Turn;

                Console.Clear();
                PrintGrid(grid, gridSizeX, gridSizeY, player1X, player1Y, player2X, player2Y);

                int currentNumber = grid[currentPlayerY, currentPlayerX];

                Console.WriteLine($"Player {(isPlayer1Turn ? 2 : 1)}, landed on number: {currentNumber}");
                Console.WriteLine();

                char input = Console.ReadKey().KeyChar;
            }
        }

        static void GetPlayerPosition(int currentPlayerX, int currentPlayerY,bool isPlayer1Turn)
        {
            Character player1 = new Character();
            Character player2 = new Character();

            Position currentPosition = new Position(currentPlayerX, currentPlayerY);

            if (isPlayer1Turn)
            {
                player1.Positions.Add(currentPosition);
            }
            else
            {
                player2.Positions.Add(currentPosition);
            }
            foreach (Position position in player1.Positions)
            {
                Console.WriteLine(position.ToString());
            }
        }

        // Function to print the grid and players' positions
        static void PrintGrid(int[,] grid, int gridSizeX, int gridSizeY, int player1X, int player1Y, int player2X, int player2Y)
        {
            for (int i = 0; i < gridSizeY; i++)
            {
                for (int j = 0; j < gridSizeX; j++)
                {
                    Console.Write("+----");
                }
                Console.WriteLine("+");

                for (int j = 0; j < gridSizeX; j++)
                {
                    if (i == player1Y && j == player1X)
                    {
                        Console.Write("| P1 ");
                    }
                    else if (i == player2Y && j == player2X)
                    {
                        Console.Write("| P2 ");
                    }
                    else
                    {
                        Console.Write($"|  {grid[i, j]} ");
                    }
                }
                Console.WriteLine("|");
            }

            for (int j = 0; j < gridSizeX; j++)
            {
                Console.Write("+----");
            }
            Console.WriteLine("+");

            Console.WriteLine($"Player 1: ({player1X}, {player1Y})");
            Console.WriteLine($"Player 2: ({player2X}, {player2Y})");
        }
    }

    public class Character
    {
        public List<Position> Positions = new List<Position>();
        public string Color;
        public double Score;
    }
    public class Position
    {
        public int X;
        public int Y;
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
