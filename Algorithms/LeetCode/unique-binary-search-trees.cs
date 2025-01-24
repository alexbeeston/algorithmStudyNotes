using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

// #96

public class unique_binary_search_trees
{
    public int NumTrees(int n)
    {
        int combinations = 0;
        Thing(1, n, ref combinations);
        return combinations;
    }

    private void Thing(int current, int max, ref int numCombinations)
    {
        if (current == max)
        {
            numCombinations++;
            return;
        }

        // add all remaining nodes to the left, then recurse on it
        Thing(current + 1, max, ref numCombinations);

        // add all remaining nodes to the right, then recurse on it
        Thing(current + 1, max, ref numCombinations);

        // add left and right, then recurse on both
        if (current + 1 < max)
        {
            Thing(current + 2, max, ref numCombinations);
            Thing(current + 2, max, ref numCombinations);
        }
    }
}
