namespace Algorithms.Algorithms;

public static class Knapsack_01
{
    public static double Main(int[] weights, double[] values, int capacity)
    {
        int numItems = weights.Length;
        double[,] dpTable = new double[numItems, capacity + 1];
        for (int i = 0; i < numItems; i++)
        {
            for (int j = 0; j <= capacity; j++)
            {
                double maxValueWithoutItem = i > 0 ? dpTable[i - 1, j] : 0;
                double maxValueWithItem;
                if (j - weights[i] < 0)
                {
                    maxValueWithItem = 0;
                }
                else
                {
                    maxValueWithItem = values[i] + (i > 0 ? dpTable[i - 1, j - weights[i]] : 0);
                }

                dpTable[i, j] = double.Max(maxValueWithoutItem, maxValueWithItem);
            }
        }

        return dpTable[numItems - 1, capacity];
    }
}