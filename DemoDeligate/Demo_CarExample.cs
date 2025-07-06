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

class Expalin
{
    private string text = """
                                            The provided example demonstrates tight coupling between the Car class and the NotificationServices class, as Car directly depends on a concrete implementation of NotificationServices. This makes the code less flexible, harder to test, and difficult to extend (e.g., if you want to add different notification methods like email or SMS). A better approach is to use dependency injection with an interface to achieve loose coupling, making the code more modular, testable, and maintainable.
                                            Below, I'll explain why the original example is problematic, then provide a better implementation using an interface-based approach, and show how to run it.
                                                Why the Original Example is Tightly Coupled
                                            Direct Dependency on Concrete Class:
                                            The Car class directly references the concrete NotificationServices class in its constructor and field. This means Car can only work with NotificationServices and cannot easily use a different notification mechanism (e.g., SMS, email, or logging).
                                                Lack of Flexibility:
                                            If you want to change the notification behavior (e.g., send an email instead of a console message), you’d need to modify the Car class or create a new concrete class, violating the Open/Closed Principle (software should be open for extension but closed for modification).
                                            Testing Challenges:
                                            Unit testing the Car class is harder because you can’t easily mock or substitute NotificationServices without creating a real instance, making it difficult to isolate Car's behavior.
                                                Namespace Misnomer:
                                            The namespace DelegateDemo suggests the use of delegates or events, but the example doesn’t use them, missing an opportunity to demonstrate a more flexible notification mechanism.
                          """;
}