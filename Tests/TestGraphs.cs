using Algorithms.Graphs;

namespace Tests;

[TestClass]
public class TestGraphs
{
    [TestMethod]
    public void TestBreadthFirstSearch()
    {
        WeightedAdjacencyGraph graph = new WeightedAdjacencyGraph(11);
        graph.AddEdge(0, 2, 1);
        graph.AddEdge(0, 3, 1);
        graph.AddEdge(2, 3, 1);
        graph.AddEdge(2, 4, 1);
        graph.AddEdge(2, 7, 1);
        graph.AddEdge(3, 1, 1);
        graph.AddEdge(3, 5, 1);
        graph.AddEdge(5, 6, 1);
        graph.AddEdge(5, 8, 1);
        graph.AddEdge(5, 10, 1);
        graph.AddEdge(6, 9, 1);
        graph.AddEdge(7, 4, 1);
        graph.AddEdge(9, 10, 1);
        graph.AddEdge(10, 6, 1);

        int[] trueOrdering = new int[] { 0, 2, 3, 4, 7, 1, 5, 6, 8, 10, 9 };
        int[] testOrdering = BreadthFirstSearch.Main(graph, 0).ToArray();

        for (int i = 0; i < trueOrdering.Length; i++)
        {
            Assert.IsTrue(trueOrdering[i] == testOrdering[i]);
        }
    }
}