﻿using System.Collections;

namespace Methods1;

/// <summary>
/// It's like <see cref="List{T}"/>, but it's worse because accessing the <see cref="Count"/> property throws an exception.
/// </summary>
/// <typeparam name="T">The type of elements in the list.</typeparam>
public class WorseList<T> : IList<T>
{
    private List<T> _value = new();

    public WorseList(IEnumerable<T> items)
    {
        _value = items.ToList();
    }

    public T this[int index] { get => ((IList<T>)_value)[index]; set => ((IList<T>)_value)[index] = value; }

    /// <summary>
    /// Sorry, you're not allowed to use this.
    /// </summary>
    public int Count => throw new NotImplementedException();

    public bool IsReadOnly => ((ICollection<T>)_value).IsReadOnly;

    public void Add(T item)
    {
        ((ICollection<T>)_value).Add(item);
    }

    public void Clear()
    {
        ((ICollection<T>)_value).Clear();
    }

    public bool Contains(T item)
    {
        return ((ICollection<T>)_value).Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        ((ICollection<T>)_value).CopyTo(array, arrayIndex);
    }

    public IEnumerator<T> GetEnumerator()
    {
        return ((IEnumerable<T>)_value).GetEnumerator();
    }

    public int IndexOf(T item)
    {
        return ((IList<T>)_value).IndexOf(item);
    }

    public void Insert(int index, T item)
    {
        ((IList<T>)_value).Insert(index, item);
    }

    public bool Remove(T item)
    {
        return ((ICollection<T>)_value).Remove(item);
    }

    public void RemoveAt(int index)
    {
        ((IList<T>)_value).RemoveAt(index);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_value).GetEnumerator();
    }
}
