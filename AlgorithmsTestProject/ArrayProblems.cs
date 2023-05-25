// [ ]

namespace AlgorithmsTestProject;

public static class ArrayProblems
{
    public static bool AreArraysEqual<T>(T[] xs, T[] ys)
    {
        return xs.Equals(ys);
    }

    public static void Swap<T>(T[] xs, int a, int b)
    {
        if (a == 0 && b == 0 && xs.Length == 0)
            throw new Exception("Array is empty.");

        T temp = xs[a];
        xs[a] = xs[b];
        xs[b] = temp;
    }

    public static T FirstElement<T>(T[] xs)
    {
        return xs[0];
    }

    public static T LastElement<T>(T[] xs)
    {
        return xs[^1];
    }

    public static T MiddleElement<T>(T[] xs)
    {
        return xs[xs.Length / 2];
    }

    public static void Reverse<T>(T[] xs)
    {
        Array.Reverse(xs);
    }

    public static int CountElement<T>(T[] xs, T element)
    {
        return xs.Count(x => x.Equals(element));
    }

    public static string ToCommaDelimitedString<T>(T[] xs)
    {
        return string.Join(",", xs);
    }

    // Bonus problems

    public static int Count<T>(T[] xs, Func<T, bool> predicate)
    {
        return xs.Count(predicate);
    }

    public static T Min<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static T Max<T>(T[] xs, Func<T, T, int> comparer)
    {
        throw new NotImplementedException();
    }

    public static bool HasDuplicates<T>(T[] xs)
    {
        throw new NotImplementedException();
    }
}