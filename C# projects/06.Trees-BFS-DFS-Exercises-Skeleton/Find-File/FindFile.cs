using System;
using System.IO;

public static class FindFile
{
    private static void TraverseDirDFS(DirectoryInfo dir, string spaces, string fileName)
    {
        try
        {
           
        }
        catch
        {
            Console.WriteLine($"No access to {dir}");
        }
    }

    public static void TraverseDirDFS(string directoryPath, string fileName)
    {
        TraverseDirDFS(new DirectoryInfo(directoryPath), string.Empty, fileName);
    }

    static void Main()
    {
        //Change directoryPath and fileName if needed
        //TraverseDirDFS(@"E:\", "Trees-BFS-DFS-Exercises.docx");

        string rootPath = @"D:\\"; // Example path
        TraverseDirDFS(rootPath, "06.Trees-BFS-DFS-Exercises.pdf");
    }
    static bool TraverseDirDFS(string dir, string fileName)
    {
        try
        {
            string[] files = Directory.GetFiles(dir);
            foreach (string file in files)
            {
                if (Path.GetFileName(file).Equals(fileName))
                {
                    Console.WriteLine($"{fileName} is found in {dir}.");
                    Console.WriteLine(file);
                    return true;
                }
            }
            string[] subDirectories = Directory.GetDirectories(dir);
            foreach (string subDirectory in subDirectories)
            {
                if (TraverseDirDFS(subDirectory, fileName))
                {
                    return true;    
                }
            }
        }
        catch
        {
            Console.WriteLine($"No access to {dir}");
        }
        return false;
    }
}