namespace Sorting.SortingClass;

public class BinarySearchClass
{
    public static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1, mid = 0;

        while (left <= right)
        {
            mid = (left + right) / 2;

            if (arr[mid] == target) return mid;

            if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }

        return -1;
    }
}