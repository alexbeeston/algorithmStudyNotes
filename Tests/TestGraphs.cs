using Algorithms.Graphs;

namespace Tests;

[TestClass]
public class TestGraphs
{
    [TestMethod]
    public void TestBreadthFirstSearch()
    {
        WeightedAdjacencyGraph graph = new WeightedAdjacencyGraph(3);
        graph.AddEdge(0, 1, 1);
        graph.AddEdge(0, 2, 1);
        graph.AddEdge(1, 2, 1);

        List<int> ints = BreadthFirstSearch.Main(graph, 0);
    }
}