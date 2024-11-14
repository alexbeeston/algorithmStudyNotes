namespace Algorithms.Algorithms;

public class BinarySearch
{
    public static int MainIterative(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (target < arr[mid])
            {
                right = mid - 1;
            }
            else if (target == arr[mid])
            {
                do
                {
                    mid--;
                }
                while (mid > -1 && arr[mid] == target);

                return mid + 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return -1;
    }

    public static int MainRecursive(int[] arr, int target)
    {
        return RecursiveHelper(arr, target, 0, arr.Length - 1);
    }

    private static int RecursiveHelper(int[] arr, int target, int left, int right)
    {
        if (left > right)
        {
            return -1;
        }

        int mid = (left + right) / 2;
        if (target < arr[mid])
        {
            return RecursiveHelper(arr, target, left, mid - 1);
        }
        else if (target == arr[mid])
        {
            do
            {
                mid--;
            }
            while (mid > -1 && arr[mid] == target);

            return mid + 1;
        }
        else
        {
            return RecursiveHelper(arr, target, mid + 1, right);
        }
    }
}
