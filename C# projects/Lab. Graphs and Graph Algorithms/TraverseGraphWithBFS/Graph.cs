using System;
using System.Linq;
using System.Collections.Generic;

namespace TraverseGraphWithBFS
{
    public class Graph
    {
        private static int verticesCount;
        private static LinkedList<int>[] adjecents;

        public Graph(int _verticesCount)
        {
            adjecents = new LinkedList<int>[_verticesCount];
            for (int i = 0; i < adjecents.Length; i++)
            {
                adjecents[i] = new LinkedList<int>();
            }
            verticesCount = _verticesCount;
        }

        static void Main(string[] args)
        {
            Graph graph = new Graph(4);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 0);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 3);

            Console.WriteLine("Following is Breadth First Traversal(starting from vertex 2)");
            graph.BFS(2);
        }

        public void AddEdge(int firstVertex, int secondVertex)
        {
            adjecents[firstVertex].AddLast(secondVertex);
        }

        public void BFS(int vertex)
        {
            bool[] visitedVetices = new bool[verticesCount];

            LinkedList<int> queue = new LinkedList<int>();

            visitedVetices[vertex] = true;
            queue.AddLast(vertex);

            while (queue.Any())
            {
                vertex = queue.First();
                Console.Write(vertex + " ");

                queue.RemoveFirst();
                LinkedList<int> list = adjecents[vertex];

                foreach (int adjacent in list)
                {
                    if (!visitedVetices[adjacent])
                    {
                        visitedVetices[adjacent] = true;
                        queue.AddLast(adjacent);
                    }
                }
            }
        }

        //public void ReadGraph()
        //{
        //    int verticesCount = int.Parse(Console.ReadLine());
        //}
    }
}
