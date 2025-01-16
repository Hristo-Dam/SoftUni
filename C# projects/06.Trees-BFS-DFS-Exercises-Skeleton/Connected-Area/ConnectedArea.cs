using System;
using System.Drawing;
using System.IO;

class ConnectedArea
{
    static void Main()
    {
        int heightY = int.Parse(Console.ReadLine());
        int widthX = int.Parse(Console.ReadLine());
        char[,] matrix = new char[heightY, widthX];
        ReadMatrix(heightY, widthX, matrix);
        int maxSize = 0;
        bool[,] visited = new bool[heightY, widthX];
        for (int row = 0; row < heightY; row++)
        {
            for (int col = 0; col < widthX; col++)
            {
                int areaSize = FindArea(row, col, heightY, widthX, matrix, visited);
                if (areaSize > maxSize)
                {
                    maxSize = areaSize;
                }
            }
        }



        Console.WriteLine("The largest connected area of the matrix is: " + maxSize);
    }

    static void ReadMatrix(int heightY, int widthX, char[,] matrix)
    {
        for (int y = 0; y < heightY; y++)
        {
            char[] row = Console.ReadLine().ToCharArray();
            for (int x = 0; x < widthX; x++)
            {
                matrix[y, x] = row[x];
            }
        }
    }

    private static int FindArea(int row, int col, int sizeRow, int sizeCol, char[,] matrix, bool[,] visit)
    {
        if (row >= sizeRow || row < 0 || col >= sizeCol || col < 0)
        {
            return 0;
        }
        if (visited[row, col] || matrix[row, col] != '1')
        {
            return 0;
        }

        visited[row, col] = true;
        int areaSize = 1;

        areaSize += FindArea(row + 1, col, sizeRow, sizeCol, matrix, visited);
        areaSize += FindArea(row - 1, col, sizeRow, sizeCol, matrix, visited);
        areaSize += FindArea(row, col + 1, sizeRow, sizeCol, matrix, visited);
        areaSize += FindArea(row, col - 1, sizeRow, sizeCol, matrix, visited);

        return areaSize;
    }
}