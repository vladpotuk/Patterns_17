using System;

public class PendingState<T> : IDrivingLicenseState<T>
{
    public void EnterState(T context)
    {
        Console.WriteLine("The driving license is pending approval.");
    }

    public void ExitState(T context)
    {
        Console.WriteLine("Exiting pending state of the driving license.");
    }
}
