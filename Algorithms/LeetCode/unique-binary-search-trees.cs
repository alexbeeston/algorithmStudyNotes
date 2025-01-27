using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode;

// #96

public class unique_binary_search_trees
{
    public int NumTrees_Recursive(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else if (n == 2)
        {
            return 2;
        }
        else
        {
            int combinations = 0;
            int topLimit = n - 1;
            for (int i = 0; i <= (topLimit / 2); i++)
            {
                int left = NumTrees_Recursive(i);
                int right = NumTrees_Recursive(topLimit - i);
                int multiplier = topLimit % 2 == 0 && i == topLimit / 2 ? 1 : 2;
                combinations += left * right * multiplier;
            }

            return combinations;
        }
    }
}
