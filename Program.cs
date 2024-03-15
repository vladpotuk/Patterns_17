using System;

class Program
{
    static void Main(string[] args)
    {
       
        VendingMachine vendingMachine = new VendingMachine();

        
        Console.WriteLine("Initial state:");
        vendingMachine.RequestItem();

        
        vendingMachine.AddItem(5);

      
        Console.WriteLine("\nSelecting an item:");
        vendingMachine.RequestItem();

        
        Console.WriteLine("\nSelecting another item:");
        vendingMachine.RequestItem();

        
        Console.WriteLine("\nRemaining items: " + vendingMachine.Count);

        Console.ReadLine();
    }
}
