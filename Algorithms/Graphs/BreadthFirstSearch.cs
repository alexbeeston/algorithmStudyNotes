namespace Algorithms.Graphs;

public static class BreadthFirstSearch
{
    public static List<int> Main(WeightedAdjacencyGraph graph, int rootVertex)
    {
        bool[] visited = new bool[graph.NumVertices];
        bool[] inTheQueue = new bool[graph.NumVertices];
        DataStructures.Queue<int> queue = new DataStructures.Queue<int>();
        queue.Enqueue(rootVertex);
        inTheQueue[rootVertex] = true;
        List<int> visitedVertices = new List<int>();
        while (!queue.IsEmpty)
        {
            int vertexBeingVisited = queue.Dequeue();
            foreach (WeightedEdge edge in graph.Edges[vertexBeingVisited])
            {
                if (!visited[edge.Destination] && !inTheQueue[edge.Destination])
                {
                    queue.Enqueue(edge.Destination);
                    inTheQueue[edge.Destination] = true;
                }
            }

            visited[vertexBeingVisited] = true;
            visitedVertices.Add(vertexBeingVisited);
        }

        return visitedVertices;
    }
}
