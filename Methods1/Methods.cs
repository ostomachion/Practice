﻿namespace Methods1;

/// <summary>
/// Problems to practice writing C# functions.
/// </summary>
public static class Methods
{
    /// <summary>
    /// Returns true if the specified value is positive; otherwise, false.
    /// </summary>
    public static bool IsPositive(int value)
    {
        return value > 0;
    }

    /// <summary>
    /// Returns the larger of the two inputs.
    /// </summary>
    public static int Max(int a, int b)
    {
        return a > b ? a : b;
    }

    /// <summary>
    /// Returns a new list containing the specified string repeated <paramref name="count"/> times.
    /// </summary>
    /// <param name="value">The string to repeat.</param>
    /// <param name="count">The number of times the string should be repeated</param>
    public static List<string> Repeat(string value, int count)
    {
        var list = new List<string>();
        for (var i = 0; i < count; i++)
        {
            list.Add(value);
        }

        return list;
    }

    /// <summary>
    /// Returns the zero-based index of the specified string in the specified list.
    /// Returns -1 if the list does not contain the string.
    /// </summary>
    /// <param name="haystack">The list to search.</param>
    /// <param name="needle">The string to look for in the list.</param>
    public static int IndexOf(List<string> haystack, string needle)
    {
        for (int i = 0; i < haystack.Count; i++)
        {
            if (haystack[i] == needle)
            {
                return i;
            }
        }

        return -1;
    }

    /// <summary>
    /// Returns the number of elements in the specified list.
    /// </summary>
    /// <param name="stupid">A stupid list that that crashes if you try to access its Length property.</param>
    public static int Count(WorseList<string> stupid)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the value of the Fibonacci sequence at n.
    /// The first two values of the sequence are 0 and 1.
    /// For higher inputs, the output is the sum of the previous two terms.
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }

        if (n == 1)
        {
            return 1;
        }

        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    /// <summary>
    /// Returns the last item in the specified list.
    /// </summary>
    /// <param name="items">The list to process.</param>
    public static string GetLastItem(List<string> items)
    {
        var lastIndex = items.Count - 1;
        return items[lastIndex];
        // return items[^-1];
    }

    /// <summary>
    /// Returns a new list whose items are the same as the specified list, but with the last item removed.
    /// </summary>
    /// <param name="items">The list to process.</param>
    public static List<string> RemoveLastItem(List<string> items)
    {
        var value = new List<string>();
        for (int i = 0; i < items.Count - 1; i++)
        {
            value.Add(items[i]);
        }

        return value;
    }

    /// <summary>
    /// Returns a new list whose items are the same as the specified list, but in reverse order.
    /// </summary>
    /// <param name="items">The list to process.</param>
    public static List<string> ReverseList(List<string> items)
    {
        var value = new List<string>();

        if (items.Count == 0)
        {
            return value;
        }

        var lastItem = GetLastItem(items);
        var firstItems = RemoveLastItem(items);
        var firstItemsReversed = ReverseList(firstItems);

        value.Add(lastItem);
        foreach (var item in firstItemsReversed)
        {
            value.Add(item);
        }

        return value;
    }
}