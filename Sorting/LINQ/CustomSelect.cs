namespace Sorting.LINQ;

public static class CustomSelect
{
    public static IEnumerable<TResult> MySelect<T, TResult>(this IEnumerable<T> source,
        Func<T, TResult> selector)
    {
        foreach(var item in source)
            yield return selector(item);
    }
}