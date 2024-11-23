namespace Algorithms.Graphs;

public static class BreadthFirstSearch
{
    public static List<int> Main(WeightedAdjacencyGraph graph, int rootVertex)
    {
        bool[] visited = new bool[graph.NumVertices];
        DataStructures.Queue<int> queue = new DataStructures.Queue<int>();
        queue.Enqueue(rootVertex);
        List<int> visitedVertices = new List<int>();
        while (!queue.IsEmpty)
        {
            int vertexBeingVisited = queue.Dequeue();
            foreach (WeightedEdge edge in graph.Edges[vertexBeingVisited])
            {
                if (!visited[edge.Destination])
                {
                    queue.Enqueue(edge.Destination);
                    visited[vertexBeingVisited] = true;
                }
            }

            visitedVertices.Add(vertexBeingVisited);
        }

        return visitedVertices;
    }
}
