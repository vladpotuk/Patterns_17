using System;

public class ReadyState : VendingMachineState
{
    public ReadyState(VendingMachine vendingMachine) : base(vendingMachine) { }

    public override void HandleRequest()
    {
        Console.WriteLine("Please select an item.");
        vendingMachine.State = new ItemSelectedState(vendingMachine);
    }
}
