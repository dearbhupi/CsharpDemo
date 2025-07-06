using System;

public class FireAlarmSystem
{
    // Delegate declaration
    public delegate void AlarmHandler(string location);

    public static void NotifyFireDepartment(string location)
    {
        Console.WriteLine($"🚒 Fire department notified of fire at {location}");
    }

    public static void NotifyBuildingManager(string location)
    {
        Console.WriteLine($"🏢 Building manager alerted about fire at {location}");
    }

    public static void NotifySecurityTeam(string location)
    {
        Console.WriteLine($"🛡️ Security team alerted about fire at {location}");
    }

    public static void Main()
    {
        AlarmHandler alarm;

        // Add multiple methods to the delegate (multicast)
        alarm = NotifyFireDepartment;
        alarm += NotifyBuildingManager;
        alarm += NotifySecurityTeam;

        // Invoke the multicast delegate
        alarm("Block A, 2nd Floor");
    }
}