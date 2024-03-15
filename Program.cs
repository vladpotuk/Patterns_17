class Program
{
    static void Main(string[] args)
    {
        DrivingLicense license = new DrivingLicense();
        license.ProcessApplication();
        license.Renew();
        license.Suspend();
        license.Reinstate();

        Console.ReadLine();
    }
}
