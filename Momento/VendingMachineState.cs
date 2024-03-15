using System;

public abstract class VendingMachineState
{
    protected VendingMachine vendingMachine;

    public VendingMachineState(VendingMachine vendingMachine)
    {
        this.vendingMachine = vendingMachine;
    }

    public abstract void HandleRequest();
}
