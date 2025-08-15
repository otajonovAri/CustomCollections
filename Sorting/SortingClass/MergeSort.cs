namespace Sorting.SortingClass;

public class MergeSortClass
{
    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right) return;

        int mid = (left + right) / 2;
        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);
        Merge(arr, left, mid, right);
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        var leftArr = arr[left..(mid + 1)];
        var rightArr = arr[(mid + 1)..(right + 1)];

        int i = 0, j = 0, k = left;
        while (i < leftArr.Length && j < rightArr.Length)
        {
            if (leftArr[i] <= rightArr[j]) arr[k++] = leftArr[i++];
            else arr[k++] = rightArr[j++];
        }

        while (i < leftArr.Length) arr[k++] = leftArr[i++];
        while (j < rightArr.Length) arr[k++] = rightArr[j++];
    }
}