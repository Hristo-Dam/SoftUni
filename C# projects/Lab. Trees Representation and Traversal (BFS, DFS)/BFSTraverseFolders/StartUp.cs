using System.Collections.Generic;
using SimpleTreeNode;

//namespace BFSTraverseFolders
//{
public static class DirectoryTraverserBFS
{
    static void Main(string[] args)
    {
        TreverseDirBFS(@"C:\Windows\assembly");
    }

    public static void TreverseDirBFS(string directoryPath)
    {
        Queue<DirectoryInfo> visitedDirsQueue = new Queue<DirectoryInfo>();
        visitedDirsQueue.Enqueue(new DirectoryInfo(directoryPath));

        while (visitedDirsQueue.Count > 0)
        {
            DirectoryInfo currentDir = visitedDirsQueue.Dequeue();
            Console.WriteLine(currentDir.FullName);

            DirectoryInfo[] children = currentDir.GetDirectories();

            foreach (DirectoryInfo child in children)
            {
                visitedDirsQueue.Enqueue(child);
            }
        }
    }
}
    //public class StartUp
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello, World!");
    //    }
    //}
//}
