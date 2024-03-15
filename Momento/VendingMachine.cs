using System;
using System.Xml;

public class VendingMachine
{
    private VendingMachineState state;
    private int count = 10;

    public VendingMachine()
    {
        state = new ReadyState(this);
    }

    public VendingMachineState State
    {
        get { return state; }
        set { state = value; }
    }

    public int Count
    {
        get { return count; }
        set { count = value; }
    }

    public void RequestItem()
    {
        state.HandleRequest();
    }

    public void AddItem(int number)
    {
        count += number;
        Console.WriteLine($"{number} items added. Total items: {count}");
    }

    public void DispenseItem()
    {
        count--;
        Console.WriteLine("Item dispensed. Remaining items: " + count);
    }
}
