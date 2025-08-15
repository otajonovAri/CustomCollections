namespace Sorting.SortingClass;

public class QuickSortClass
{
    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left >= right) return;
        
        int pivot = arr[(left+ right)/2];
        int index = Partition(arr, left, right, pivot);

        QuickSort(arr, left, index - 1);
        QuickSort(arr, index, right);
    }

    private static int Partition(int[] arr, int left, int right, int pivot)
    {
        while (left <= right)
        {
            while (arr[left] < pivot) left++;
            while (arr[right] > pivot) right--;

            if (left <= right)
            {
                (arr[left], arr[right]) = (arr[right], arr[left]);
                left++; right--;
            }
        }
        return left;
    }
}