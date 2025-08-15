namespace Sorting.Stack;

public class StackArray<T>
{
    private T[] items;
    private int top;

    public StackArray(int capacity)
    {
        items = new T[capacity];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == items.Length - 1)
            throw new InvalidOperationException("Stack is full");

        items[++top] = item;
    }

    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return items[top--];
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return items[top];
    }

    public bool IsEmpty() => top == -1;

    public int Count => top + 1;
}