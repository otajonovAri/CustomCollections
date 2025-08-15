namespace Sorting.Queue;

public class QueueArray<T>
{
    private T[] items;
    private int front, rear, count;

    public QueueArray(int capacity)
    {
        items = new T[capacity];
        front = 0;
        rear = -1;
        count = 0;
    }

    public void Enqueue(T item)
    {
        if (count == items.Length)
            throw new InvalidOperationException("Queue is full");

        rear = (rear + 1) % items.Length; 
        items[rear] = item;
        count++;
    }

    public T Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        var value = items[front];
        front = (front + 1) % items.Length;
        count--;
        return value;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Queue is empty");

        return items[front];
    }

    public bool IsEmpty() => count == 0;

    public int Count => count;
}