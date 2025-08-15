namespace Sorting.LinkedList;

public class StackLinkedList<T>
{
    private Node<T> top;

    public void Push(T item)
    {
        var node = new Node<T>(item);
        node.Next = top;
        top = node;
    }

    public T Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException("Stack is empty");

        var value = top.Data;
        top = top.Next;
        return value;
    }

    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Stack is empty");

        return top.Data;
    }

    private bool IsEmpty() => top == null!;
}