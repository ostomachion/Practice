namespace Methods1.Tests;

public class MethodsTests
{
    [Theory]
    [InlineData(int.MinValue, false)]
    [InlineData(-1, false)]
    [InlineData(0, false)]
    [InlineData(1, true)]
    [InlineData(int.MaxValue, true)]
    public void IsPositive(int value, bool expected)
    {
        var actual = Methods.IsPositive(value);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 1, 2)]
    [InlineData(5, 5, 5)]
    [InlineData(-20, 20, 20)]
    [InlineData(0, 100, 100)]
    [InlineData(int.MaxValue, int.MinValue, int.MaxValue)]
    [InlineData(int.MinValue, int.MaxValue, int.MaxValue)]
    public void Max(int a, int b, int expected)
    {
        var actual = Methods.Max(a, b);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("hello", 5)]
    [InlineData("world", 1)]
    [InlineData("goodbye", 0)]
    [InlineData("", 20)]
    public void Repeat(string value, int count)
    {
        var actual = Methods.Repeat(value, count);
        Assert.Equal(count, actual.Count);
        Assert.All(actual, item => Assert.Equal(item, value));
    }

    [Theory]
    [InlineData("hello", new[] { "hello", "world" }, 0)]
    [InlineData("world", new[] { "hello", "world" }, 1)]
    [InlineData("", new[] { "hello", "", "world" }, 1)]
    [InlineData("goodbye", new[] { "hello", "world" }, -1)]
    [InlineData("Hello", new[] { "hello", "world" }, -1)]
    [InlineData("", new[] { "hello", "world" }, -1)]
    [InlineData("hello", new string[0], -1)]
    [InlineData("", new string[] { }, -1)]
    public void IndexOf(string needle, string[] haystack, int expected)
    {
        var list = haystack.ToList();
        var actual = Methods.IndexOf(list, needle);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new[] { "hello", "world" }, 2)]
    [InlineData(new[] { "hello", "world", "okay", "whatever", "goodbye" }, 5)]
    [InlineData(new[] { "single" }, 1)]
    [InlineData(new[] { "", "", "" }, 3)]
    [InlineData(new string[0], 0)]
    public void Count(string[] items, int expected)
    {
        var stupid = new WorseList<string>(items);
        var actual = Methods.Count(stupid);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    [InlineData(19, 4181)]
    public void Fibonacci(int n, int expected)
    {
        var actual = Methods.Fibonacci(n);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new[] { "hello", "world" }, "world")]
    [InlineData(new[] { "hello" }, "hello")]
    [InlineData(new[] { "hello", "world", "" }, "")]
    public void GetLastItem(string[] items, string expected)
    {
        var list = items.ToList();
        var actual = Methods.GetLastItem(list);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new[] { "hello", "world" }, new[] { "hello" })]
    [InlineData(new[] { "hello" }, new string[0])]
    [InlineData(new[] { "hello", "world", "" }, new[] { "hello", "world" })]
    public void RemoveLastItem(string[] items, string[] expected)
    {
        var list = items.ToList();
        var actual = Methods.RemoveLastItem(list);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new[] { "hello", "world" }, new[] { "world", "hello" })]
    [InlineData(new[] { "hello", "world", "okay", "whatever", "goodbye" }, new[] { "goodbye", "whatever", "okay", "world", "hello" })]
    [InlineData(new[] { "hello" }, new[] { "hello" })]
    [InlineData(new[] { "hello", "world", "" }, new[] { "", "world", "hello" })]
    public void ReverseList(string[] items, string[] expected)
    {
        var list = items.ToList();
        var actual = Methods.ReverseList(list);
        Assert.Equal(expected, actual);
    }
}