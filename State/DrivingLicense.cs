using System;

public class DrivingLicense
{
    public bool IsValid { get; private set; } = true;

    public void ProcessApplication()
    {
        Console.WriteLine("Processing driving license application...");
    }

    public void Reinstate()
    {
        Console.WriteLine("Reinstating driving license...");
        IsValid = true;
    }

    public void Renew()
    {
        Console.WriteLine("Renewing driving license...");
    }

    public void Suspend()
    {
        Console.WriteLine("Suspending driving license...");
        IsValid = false;
    }
}
