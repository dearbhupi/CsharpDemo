// Example notification handlers (equivalent to NotificationServices)
using System;

namespace DemoDeligate;

public class NotificationServices
{
    public static void ConsoleNotification(string message)
    {
        Console.WriteLine($"Console Notification: {message}");
    }

    public static void EmailNotification(string message)
    {
        Console.WriteLine($"Email Notification: Sending email with message - {message}");
    }

    public static void LogNotification(string message)
    {
        Console.WriteLine($"Log Notification: Logging to file - {message}");
    }
}