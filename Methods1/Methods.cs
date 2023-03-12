namespace Methods1;

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
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the larger of the two inputs.
    /// </summary>
    public static int Max(int a, int b)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the largest of the three inputs.
    /// </summary>
    public static int Max(int a, int b, int c)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    ///  Returns the largest item in the list.
    /// </summary>
    /// <exception cref="Exception">If the specified list is empty.</exception>
    public static int Max(List<int> items)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns a new list containing the specified string repeated <paramref name="count"/> times.
    /// </summary>
    /// <param name="value">The string to repeat.</param>
    /// <param name="count">The number of times the string should be repeated</param>
    public static List<string> Repeat(string value, int count)
    {
        // Assume count isn't negative.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns true if the specified list contains the specified item; otherwise; false.
    /// </summary>
    public static bool Contains(List<string> items, string value)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the zero-based index of the specified string in the specified list.
    /// </summary>
    /// <param name="haystack">The list to search.</param>
    /// <param name="needle">The string to look for in the list.</param>
    /// <exception cref="Exception">If the item is not in the list.</exception>
    public static int IndexOf(List<string> haystack, string needle)
    {
        throw new NotImplementedException();
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
        // Assume n isn't negative.
        // Hint: Use recursion.
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns the last item in the specified list.
    /// </summary>
    /// <param name="items">The list to process.</param>
    public static string GetLastItem(List<string> items)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns a new list whose items are the same as the specified list, but with the last item removed.
    /// </summary>
    /// <param name="items">The list to process.</param>
    public static List<string> RemoveLastItem(List<string> items)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returns a new list whose items are the same as the specified list, but in reverse order.
    /// </summary>
    /// <param name="items">The list to process.</param>
    public static List<string> ReverseList(List<string> items)
    {
        // This one is tricky.
        // Hint: Use GetLastItem, RemoveLastItem, and recursion.
        throw new NotImplementedException();
    }
}