using System;


namespace DeligateDemo;

public class NotificationInterface
{
    // Introduce the Interface for Notification services
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}

public class SMSNotificationServices : NotificationInterface.INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending notification by SMS: " + message);
        }
    }



public class EmailNotificationServices : NotificationInterface.INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sending notification by email: " + message);
        }
    }



