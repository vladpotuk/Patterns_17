using System;

public class VendingMachineObserver : IObserver
{
    public void Update(int count)
    {
        Console.WriteLine($"Current count: {count}");
    }
}
