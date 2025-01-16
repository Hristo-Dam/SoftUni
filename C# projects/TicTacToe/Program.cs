namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            GameLoop();
        }

        static void GameLoop()
        {
            // Player 1 is O
            // Player 2 is X
            // Empty slot is ' ' (whitespace)
            char[,] board = {
                {' ', ' ', ' '},
                {' ', ' ', ' '},
                {' ', ' ', ' '}
            };
            char playerTurn = 'O';
            char winner = ' '; // ' ' means no winner

            Draw(board);
            while (true)
            {
                Console.Write($"Player {playerTurn} turn: ");
                string input = Console.ReadLine().ToUpper(); // eg. A1 FIX:.ToUpper() so that the user can use lowercase for input
                if (input == "END")
                {
                    EndGame(winner);
                    return;
                }
                //order of input(command)

                int x;
                int y;

                // Mark the move
                bool validTurn = false;
                while(!validTurn)
                {
                    x = CheckInput(input)[0];
                    y = CheckInput(input)[1];

                    if (board[y, x] == ' ')
                    {
                        validTurn = true;
                        board[y, x] = playerTurn; // bug fix: player can no longer take other player's spots
                    }
                    else if (board[y, x] == 'O' || board[y, x] == 'X')
                    {
                        Draw(board);
                        Console.WriteLine("Try again!");
                        Console.Write($"Player {playerTurn} turn: ");
                        input = Console.ReadLine().ToUpper();
                    }
                }
               
                // Refresh the current board on the console
                Draw(board);

                // Check win condition
                winner = CheckWinCondition(board);
                if (winner != ' ')// bug
                {
                    EndGame(winner);
                    return;
                }

                // Switch turns
                if (playerTurn == 'X')
                {
                    playerTurn = 'O';
                }
                else
                {
                    playerTurn = 'X';
                }
            }
        }

        static char CheckWinCondition(char[,] board)
        {
            char[] players = { 'X', 'O' };
            foreach (char p in players)
            {
                // rows and columns
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
                //diagonals
                if ((board[0, 0] == p && board[1, 1] == p && board[2, 2] == p)
                    ||
                    (board[0, 2] == p && board[1, 1] == p && board[2, 0] == p))
                {
                    return p;
                }
            }

            //filled board?
            bool gameFinished = true;
            foreach (char square in board)
            {
                if (square == ' ')
                {
                    gameFinished = false;
                    break;
                }
            }
            //draw or another turn
            if (!gameFinished)
            {
                return ' ';
            }
            else
            {
                return 'D';
            }
        }

        static void Draw(char[,] board)
        {
            Console.Clear();
            Console.WriteLine("    A   B   C  ");
            Console.WriteLine("  -------------");
            Console.WriteLine($"1 |5 {board[0, 0]} | {board[0, 1]} | {board[0, 2]} |");
            Console.WriteLine("  -------------");
            Console.WriteLine($"2 | {board[1, 0]} | {board[1, 1]} | {board[1, 2]} |");
            Console.WriteLine("  -------------");
            Console.WriteLine($"3 | {board[2, 0]} | {board[2, 1]} | {board[2, 2]} |");
            Console.WriteLine("  -------------");
        }

        static void EndGame(char winner)
        {
            Console.WriteLine("Game Over!");

            if (winner == 'D')
            {
                Console.WriteLine("Draw!");
            }
            else if (winner != ' ')
            {
                Console.WriteLine($"Player {winner} wins");
            }
        }

        static int[] CheckInput(string input)
        {
            char letter = ' ';
            char num = ' ';
            if (input[0] >= 48 && input[0] <= 57)
            {
                num = input[0];
                letter = input[1];
            }
            else
            {
                num = input[1];
                letter = input[0];
            }

            int y = int.Parse("" + num) - 1;
            int x;

            switch (letter)
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

            int[] coordinates = new int[2] {x, y};
            return coordinates;
        }
    }
}