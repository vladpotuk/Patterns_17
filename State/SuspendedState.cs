using System;

public class SuspendedState<T> : IDrivingLicenseState<T>
{
    public void EnterState(T context)
    {
        Console.WriteLine("The driving license is suspended.");
    }

    public void ExitState(T context)
    {
        Console.WriteLine("Exiting suspended state of the driving license.");
    }
}
