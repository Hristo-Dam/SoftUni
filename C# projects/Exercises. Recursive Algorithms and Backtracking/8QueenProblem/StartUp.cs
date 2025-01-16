namespace _8QueenProblem
{
    internal class StartUp
    {
        static int count = 0;
        static void Main(string[] args)
        {
            int size = 8;
            QueensProblem(new bool[size, size], new int[size, size], 0);
            Console.WriteLine(count);
        }

        static void QueensProblem(bool[,] board, int[,] occupied, int columnIndex)
        {
            if (columnIndex == board.GetLength(0)) //The .GetLength(0) method returns number of elements in the row direction in a multidimensional array.
                                                   //For a 2x6 array that is 2.
            {
                count++;
                return;
            }

            for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
            {
                if (occupied[rowIndex, columnIndex] == 0)
                {
                    // Place queen
                    board[rowIndex, columnIndex] = true;

                    // Mark impossible
                    Occupied(occupied, +1, rowIndex, columnIndex);

                    // Recursivly QueensProblem
                    QueensProblem(board, occupied, columnIndex + 1);
                    // UnPlace queen
                    board[rowIndex, columnIndex] = false;

                    // Unmark
                    Occupied(occupied, -1, rowIndex, columnIndex);
                }
            }
        }

        static void Occupied(int[,] occupied, int value, int rowIndex, int columnIndex)
        {
            for (int i = 0; i < occupied.GetLength(0); i++)
            {
                // For lines
                occupied[i, columnIndex] += value;
                occupied[rowIndex, i] += value;

                // For diagonals
                if (columnIndex + i < occupied.GetLength(0) &&
                    rowIndex + i < occupied.GetLength(0))
                {
                    occupied[rowIndex + i, columnIndex + i] += value;
                }

                if (columnIndex + i < occupied.GetLength(0) &&
                    rowIndex - i >= 0)
                {
                    occupied[rowIndex - i, columnIndex + i] += value;
                }

            }
        }
    }
}

