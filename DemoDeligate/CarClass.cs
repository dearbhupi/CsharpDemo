using System;


namespace DeligateDemo;



public class Car
{
    // first create the instance of NotificationService 
    private NotificationServices _notificationServices = new NotificationServices();
    
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