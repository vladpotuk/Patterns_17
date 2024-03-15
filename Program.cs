using System;

class Program
{
    static void Main(string[] args)
    {
        VendingMachine vendingMachine = new VendingMachine();
        var observer = new VendingMachineObserver();
        vendingMachine.AddObserver(observer);

        vendingMachine.AddItem(5);
        vendingMachine.DispenseItem();

        Console.ReadLine();
    }
}
