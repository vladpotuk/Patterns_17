using System;
using System.Collections.Generic;

public class TaskManager<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public List<T> GetItems()
    {
        return items;
    }
}
