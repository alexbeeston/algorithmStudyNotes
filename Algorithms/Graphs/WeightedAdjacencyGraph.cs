using System.Security.Cryptography.X509Certificates;

namespace Algorithms.Graphs;

public class WeightedAdjacencyGraph
{
    public WeightedAdjacencyGraph(int numVertices)
    {
        NumVertices = numVertices;
        Edges = new List<WeightedEdge>[numVertices];
        for (int i = 0; i < numVertices; i++)
        {
            Edges[i] = new List<WeightedEdge>();
        }
    }

    public int NumVertices { get; private set; }

    public void AddEdge(int sourceVertex, int destinationVertex, int weight)
    {
        if (sourceVertex < 0 || sourceVertex > NumVertices - 1)
        {
            throw new ArgumentException("Invalid vertex index");
        }

        if (Edges[sourceVertex].Any(x => x.Destination == destinationVertex))
        {
            throw new Exception("Edge already exists");
        }

        Edges[sourceVertex].Add(new WeightedEdge(destinationVertex, weight));
        Edges[sourceVertex] = Edges[sourceVertex].OrderBy(x => x.Destination).ToList();
    }

    public List<WeightedEdge>[] Edges { get; set; }

}

public class WeightedEdge
{
    public WeightedEdge(int destination, int weight)
    {
        Destination = destination;
        Weight = weight;
    }

    public int Destination { get; set; }

    public int Weight { get; set; }
}

