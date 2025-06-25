using System;
using System.Collections.Generic;

namespace LimitedSizeStack;

public class LimitedSizeStack<T>
{
    public LinkedList<T> Items { get; }
    public int UndoLimit;

    public LimitedSizeStack(int undoLimit)
    {
        Items = new LinkedList<T>();
        UndoLimit = undoLimit;
    }

    public void Push(T item)
    {
        if (UndoLimit == 0)
            return;
        if (Items.Count == UndoLimit)
            Items.RemoveFirst();
        Items.AddLast(item);
    }

    public T Pop()
    {
        if (Items.Count == 0) throw new InvalidOperationException();
        var result = Items.Last.Value;
        Items.RemoveLast();
        return result;
    }

    public int Count => Items.Count;
}