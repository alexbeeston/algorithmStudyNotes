namespace Algorithms.LeetCode;

public class next_permutation
{
    public void NextPermutation(int[] nums)
    {
        if (nums.Length == 1)
        {
            return;
        }

        // locate right-most element that has an item larger than it to its right, and then select the 
        int indexOfSmallestValueThatIsGreaterThanI = -1;
        int i = nums.Length - 2;
        for (; i >= 0; i--)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] > nums[i])
                {
                    if (indexOfSmallestValueThatIsGreaterThanI == -1)
                    {
                        indexOfSmallestValueThatIsGreaterThanI = j;
                    }
                    else if (nums[j] < nums[indexOfSmallestValueThatIsGreaterThanI])
                    {
                        indexOfSmallestValueThatIsGreaterThanI = j;
                    }
                }
            }

            if (indexOfSmallestValueThatIsGreaterThanI != -1)
            {
                break;
            }
        }

        if (indexOfSmallestValueThatIsGreaterThanI != -1 && i != -1)
        {
            Swap(nums, i, indexOfSmallestValueThatIsGreaterThanI);
        }

        for (i = i + 1; i < nums.Length - 1; i++)
        {
            int indexOfMinValue = i;
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] < nums[indexOfMinValue])
                {
                    indexOfMinValue = j;
                }
            }

            Swap(nums, i, indexOfMinValue);
        }
    }

    private void Swap(int[] nums, int i, int j)
    {
        int tempValue = nums[i];
        nums[i] = nums[j];
        nums[j] = tempValue;
    }
}
