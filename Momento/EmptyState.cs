using System;

public class EmptyState : VendingMachineState
{
    public EmptyState(VendingMachine vendingMachine) : base(vendingMachine) { }

    public override void HandleRequest()
    {
        Console.WriteLine("Machine is empty. Please add items.");
    }
}
