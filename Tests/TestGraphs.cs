using Algorithms.Graphs;
using Algorithms.LeetCode;

namespace Tests;

[TestClass]
public class TestGraphs
{
    [TestMethod]
    public void Dog()
    {
        container_with_most_water s = new();
        s.MaxArea([1, 2, 4, 3]);
    }

    [TestInitialize]
    public void Init()
    {
        testGraph.AddEdge(0, 2, 1);
        testGraph.AddEdge(0, 3, 1);
        testGraph.AddEdge(2, 3, 1);
        testGraph.AddEdge(2, 4, 1);
        testGraph.AddEdge(2, 7, 1);
        testGraph.AddEdge(3, 1, 1);
        testGraph.AddEdge(3, 5, 1);
        testGraph.AddEdge(5, 6, 1);
        testGraph.AddEdge(5, 8, 1);
        testGraph.AddEdge(5, 10, 1);
        testGraph.AddEdge(6, 9, 1);
        testGraph.AddEdge(7, 4, 1);
        testGraph.AddEdge(9, 10, 1);
        testGraph.AddEdge(10, 6, 1);
    }

    [TestMethod]
    public void TestBreadthFirstSearch()
    {
        int[] trueOrdering = new int[] { 0, 2, 3, 4, 7, 1, 5, 6, 8, 10, 9 };
        int[] testOrdering = BreadthFirstSearch.Main(testGraph, 0).ToArray();

        for (int i = 0; i < trueOrdering.Length; i++)
        {
            Assert.IsTrue(trueOrdering[i] == testOrdering[i]);
        }
    }

    [TestMethod]
    public void TestDepthFirstSearch()
    {
        int[] trueOrdering = new int[] { 0, 3, 5, 10, 8, 6, 9, 1, 2, 7, 4 };
        int[] testOrdering = DepthFirstSearch.Main(testGraph, 0).ToArray();

        for (int i = 0; i < trueOrdering.Length; i++)
        {
            Assert.IsTrue(trueOrdering[i] == testOrdering[i]);
        }
    }

    private readonly WeightedAdjacencyGraph testGraph = new WeightedAdjacencyGraph(11);
}