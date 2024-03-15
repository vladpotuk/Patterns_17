using System;

public class ActiveState<T> : IDrivingLicenseState<T>
{
    public void EnterState(T context)
    {
        Console.WriteLine("The driving license is active.");
    }

    public void ExitState(T context)
    {
        Console.WriteLine("Exiting active state of the driving license.");
    }
}
