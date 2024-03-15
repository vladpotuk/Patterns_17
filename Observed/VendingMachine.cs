using System;
using System.Collections.Generic;

public class VendingMachine
{
    private int count = 10;
    private List<IObserver> observers = new List<IObserver>();

    public int Count
    {
        get { return count; }
        set
        {
            count = value;
            NotifyObservers();
        }
    }

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(count);
        }
    }

    public void AddItem(int number)
    {
        Count += number;
        Console.WriteLine($"{number} items added. Total items: {Count}");
    }

    public void DispenseItem()
    {
        Count--;
        Console.WriteLine("Item dispensed. Remaining items: " + Count);
    }
}
