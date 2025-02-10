namespace MatrixPath
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int[,] matrix = new int[h, w];

            for (int i = 0; i < h; i++)
            {
                string[] row = Console.ReadLine().Split(' ');
                for (int j = 0; j < w; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }

            if (FindPath(matrix, h, w))
            {
                Console.WriteLine("There is a path!");
            }
            else
            {
                Console.WriteLine("No path!");
            }
        }

        static bool FindPath(int[,] matrix, int h, int w)
        {
            bool[,] visited = new bool[h, w];
            return DFS(matrix, visited, 0, 0, h, w);
        }

        static bool DFS(int[,] matrix, bool[,] visited, int row, int col, int h, int w)
        {
            if (row == h - 1)
            {
                return true;
            }

            visited[row, col] = true;

            int[] dRow = { 1, 1, 1 };
            int[] dCol = { 0, -1, 1 };

            for (int i = 0; i < 3; i++)
            {
                int newRow = row + dRow[i];
                int newCol = col + dCol[i];

                if (IsValid(newRow, newCol, h, w) && !visited[newRow, newCol] && matrix[newRow, newCol] > matrix[row, col])
                {
                    if (DFS(matrix, visited, newRow, newCol, h, w))
                    {
                        return true;
                    }
                }
            }

            visited[row, col] = false;
            return false;
        }

        static bool IsValid(int row, int col, int h, int w)
        {
            return row >= 0 && row < h && col >= 0 && col < w;
        }
    }
}
