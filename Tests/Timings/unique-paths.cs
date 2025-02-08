using Algorithms.LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Timings;

[TestClass]
public class UniquePathsTest
{
    const int M = 300;
    const int N = 300;

    [TestMethod]
    public void EnsureCorrectness()
    {
        for (int m = 1; m < 5; m++)
        {
            for (int n = 1; n < 5; n++)
            {
                int recursiveMethod = unique_paths.Recursive(m, n);
                int dynamicMethod = unique_paths.Dynamic(m, n);
                int recursiveDynamic = unique_paths.RecursiveDynamic(m, n);

                Assert.IsTrue(recursiveMethod == dynamicMethod);
                Assert.IsTrue(dynamicMethod == recursiveDynamic);

                if (m == 3 && n == 7)
                {
                    Assert.IsTrue(recursiveMethod == 28);
                }

                if (m == 3 && n == 2)
                {
                    Assert.IsTrue(recursiveMethod == 3);
                }
            }
        }
    }

    //[TestMethod] // this method is so slow it can't finish M = 18 and N = 18 in any reasonable time. Grows exponentially
    //public void Recursive()
    //{
    //    for (int m = 1; m < M; m++)
    //    {
    //        for (int n = 1; n < N; n++)
    //        {
    //            unique_paths.Recursive(m, n);
    //        }
    //    }
    //}

    [TestMethod]
    public void Dynamic()
    {
        for (int m = 1; m < M; m++)
        {
            for (int n = 1; n < N; n++)
            {
                unique_paths.Dynamic(m, n);
            }
        }
    }
    [TestMethod]
    public void RecursiveDynamic()
    {
        for (int m = 1; m < M; m++)
        {
            for (int n = 1; n < N; n++)
            {
                unique_paths.RecursiveDynamic(m, n);
            }
        }
    }
}
