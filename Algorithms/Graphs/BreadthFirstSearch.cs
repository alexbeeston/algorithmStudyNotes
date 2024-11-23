namespace Algorithms.Graphs;

public static class BreadthFirstSearch
{
    /// <summary>
    /// For any node X, if X has edges to multiple nodes, the algorithm will visit the node with the smaller weight first.
    /// </summary>
    /// <param name="graph"></param>
    /// <param name="rootVertex"></param>
    /// <returns></returns>
    public static List<int> Main(WeightedAdjacencyGraph graph, int rootVertex)
    {
        bool[] visited = new bool[graph.NumVertices];
        DataStructures.Queue<int> queue = new DataStructures.Queue<int>();
        queue.Enqueue(rootVertex);
        List<int> explorationOrder = new List<int>(); // could optimize for space by multi-purposing the queue; just reverse the order of the queue and that's what we return.
        while (!queue.IsEmpty)
        {
            int vertexBeingExplored = queue.Dequeue();
            foreach (WeightedEdge edge in graph.Edges[vertexBeingExplored])
            {
                if (!visited[edge.Destination])
                {
                    queue.Enqueue(edge.Destination);
                    visited[edge.Destination] = true;
                }
            }

            explorationOrder.Add(vertexBeingExplored);
        }

        return explorationOrder;
    }
}
