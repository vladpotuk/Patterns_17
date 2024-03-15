using System;

public class ItemSelectedState : VendingMachineState
{
    public ItemSelectedState(VendingMachine vendingMachine) : base(vendingMachine) { }

    public override void HandleRequest()
    {
        Console.WriteLine("Item dispensed.");
        vendingMachine.DispenseItem();

        if (vendingMachine.Count > 0)
            vendingMachine.State = new ReadyState(vendingMachine);
        else
            vendingMachine.State = new EmptyState(vendingMachine);
    }
}
