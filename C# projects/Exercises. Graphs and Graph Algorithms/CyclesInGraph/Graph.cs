using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclesInGraph
{
    public class Graph
    {
        private static int verticesCount;
        private static List<int>[] adjecents;

        public Graph(int _verticesCount)
        {
            adjecents = new List<int>[_verticesCount];
            for (int i = 0; i < adjecents.Length; i++)
            {
                adjecents[i] = new List<int>();
            }
            verticesCount = _verticesCount;
        }

        public void AddEdge(int firstVertex, int secondVertex)
        {
            adjecents[firstVertex].Add(secondVertex);
        }

        private bool IsCyclic()
        {
            bool[] visited = new bool[verticesCount];
            for (int i = 0;i < verticesCount; i++)
            {
                visited[i] = false;
            }

            for (int u = 0; u < verticesCount; u++)
            {
                if (!visited[u])
                {
                    if (IsCyclicUtil(u, visited, -1))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool IsCyclicUtil(int vertex, bool[] visited, int parent)
        {
            visited[vertex] = true;

            foreach (int i in adjecents[vertex])
            {
                if (!visited[i])
                {
                    if (IsCyclicUtil(i, visited, vertex))
                    {
                        return true;
                    }
                }
                else if (i != parent)
                {
                    return true;
                }
            }

            return false;
        }

        public static Graph ReadGraph()
        {
            int verticesCount = int.Parse(Console.ReadLine());
            Graph graph = new Graph(verticesCount);

            int edgesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < edgesCount; i++)
            {
                int[] edgeArr = Console.ReadLine()
                    .Split("-")
                    .Select(int.Parse)
                    .ToArray();

                graph.AddEdge(edgeArr[0], edgeArr[1]);
            }

            return graph;
        }
    }
}
