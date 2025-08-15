namespace Sorting.PriorityQueue;

public class PriorityQueue<T> where T : IComparable<T>
{
    private List<T> heap = new List<T>();

    public void Enqueue(T item)
    {
        heap.Add(item);

        int i = heap.Count - 1;

        while (i > 0 && heap[(i - 1) / 2].CompareTo(heap[i]) > 0)
        {
            (heap[i], heap[(i - 1) / 2]) = (heap[(i - 1) / 2], heap[i]);
            i = (i - 1) / 2;
        }
    }

    public T Dequeue()
    {
        if (heap.Count == 0) throw new InvalidOperationException("Empty");

        T root = heap[0];
        heap[0] = heap[^1];
        heap.RemoveAt(heap.Count - 1);

        int i = 0;
        while (true)
        {
            int left = 2 * i + 1, right = 2 * i + 2, smallest = i;

            if (left < heap.Count && heap[left].CompareTo(heap[smallest]) < 0) smallest = left;
            if (right < heap.Count && heap[right].CompareTo(heap[smallest]) < 0) smallest = right;

            if (smallest == i) break;

            (heap[i], heap[smallest]) = (heap[smallest], heap[i]);
            i = smallest;
        }

        return root;
    }

    public int Count => heap.Count;
}