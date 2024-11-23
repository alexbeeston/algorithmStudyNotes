namespace Algorithms.Graphs;

public static class DepthFirstSearch
{
    /// <summary>
    /// For any node X, if X has edges to multiple nodes, the algorithm will visit the vertex whose edge has higher weight.
    /// </summary>
    /// <param name="graph"></param>
    /// <param name="source"></param>
    /// <returns></returns>
    public static List<int> Main(WeightedAdjacencyGraph graph, int source)
    {
        bool[] visited = new bool[graph.NumVertices];
        DataStructures.Stack<int> stack = new DataStructures.Stack<int>();
        stack.Push(source);
        visited[source] = true;
        List<int> explorationOrder = new List<int>();

        while (!stack.IsEmpty())
        {
            int vertexBeingExplored = stack.Pop();
            foreach (WeightedEdge edge in graph.Edges[vertexBeingExplored])
            {
                if (!visited[edge.Destination])
                {
                    stack.Push(edge.Destination);
                    visited[edge.Destination] = true;
                }
            }

            explorationOrder.Add(vertexBeingExplored);
        }

        return explorationOrder;
    }
}
