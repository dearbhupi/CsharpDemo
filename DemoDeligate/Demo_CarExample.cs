using System;


namespace DeligateDemo;

public class NotificationServices

{
    public void SendNotification(string message)
    {
        Console.WriteLine("Sending notification : " + message);
    }
    
}


public class Car
{
    private NotificationServices _notificationServices;
    
    // create constructor for the class which accept the Notification services
    public Car(NotificationServices notificationServices)
    {
        _notificationServices = notificationServices;
    }

    public void StartEngine()
    {
        Console.WriteLine("Engine starting...");
        
        // sending notification after starting the engine
        _notificationServices.SendNotification("Someone Start my Car and Engine starting...");
    }
}