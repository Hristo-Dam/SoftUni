namespace TraverseGraphWithDFS
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

        static void Main(string[] args)
        {
            Graph graph = ReadGraph();

            int startVertex = int.Parse(Console.ReadLine());

            Console.WriteLine($"Following is Depth First Traversal starting from vertex {startVertex}");

            graph.DFS(startVertex);
        }

        public void AddEdge(int firstVertex, int secondVertex)
        {
            adjecents[firstVertex].Add(secondVertex);
        }

        public void DFS(int vertex)
        {
            bool[] visited = new bool[verticesCount];

            DFSUtil(vertex, visited);
        }

        public void DFSUtil(int vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.Write(vertex + " ");

            List<int> verticesList = adjecents[vertex];
            foreach (int v in verticesList)
            {
                if (!visited[v])
                {
                    DFSUtil(v, visited);
                }
            }
        }

        public static Graph ReadGraph()
        {
            int verticesCount = int.Parse(Console.ReadLine());
            Graph graph = new Graph(verticesCount);

            int edgesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < edgesCount; i++)
            {
                int[] edgeArr = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                graph.AddEdge(edgeArr[0], edgeArr[1]);
            }

            return graph;
        }
    }
}
