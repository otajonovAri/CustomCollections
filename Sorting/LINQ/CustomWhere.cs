namespace Sorting.LINQ;

public static class CustomWhere
{
    public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source,
        Func<T, bool> predicate)
    {
        foreach(var item in source)
            if(predicate(item))
                yield return item;
    }
}
