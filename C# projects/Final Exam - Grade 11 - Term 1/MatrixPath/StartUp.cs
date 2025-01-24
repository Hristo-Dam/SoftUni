namespace MatrixPath
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int[,] matrix = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                string[] row = Console.ReadLine()
                    .Split(' ')
                    .ToArray();
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            if (FindPath(matrix, height, width))
            {
                Console.WriteLine("Path 1..9 is found!");
            }
            else
            {
                Console.WriteLine("Path 1..9 is not found!");
            }
        }
        public static bool Trevers(int[,] matrix, bool[,] visited, int row, int col, int target)
        {
            if (target > 9)
            {
                return true;
            }
            if (row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }
            if (visited[row, col] || matrix[row, col] != target)
            {
                return false;
            }

            visited[row, col] = true;

            bool found = Trevers(matrix, visited, row - 1, col, target + 1) ||
                            Trevers(matrix, visited, row + 1, col, target + 1) ||
                            Trevers(matrix, visited, row, col - 1, target + 1) ||
                            Trevers(matrix, visited, row, col + 1, target + 1);

            visited[row, col] = false;
            return found;
        }
        public static bool FindPath(int[,] matrix, int rows, int cols)
        {
            bool[,] visited = new bool[rows, cols];
            return Trevers(matrix, visited, 0, 0, 1);
        }
    }
}
