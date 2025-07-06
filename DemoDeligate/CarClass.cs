//using DeligateDemo;

namespace DemoDeligate;



// Define a delegate for the notification event
    public delegate void NotificationHandler(string message);

    // Car class using events instead of a concrete notification service
    public class Car
    {
        // Event to notify subscribers when something happens
        public event NotificationHandler OnEngineStarted;

        public void StartEngine()
        {
            Console.WriteLine("Engine starting...");
            // Raise the event with a message
            OnEngineStarted?.Invoke("The car engine has started.");
        }
    }



    class explanation
    {
        private string text = """
                              Key Improvements in the After Code
                              Loose Coupling:
                              The Car class no longer depends on a concrete NotificationServices class. Instead, it uses an event (OnEngineStarted) based on a delegate (NotificationHandler).
                              Any method matching the delegate signature (void (string)) can subscribe to the event, making the system highly flexible.
                              Multiple Subscribers:
                              The event-based approach allows multiple notification handlers (e.g., console, email, logging) to be notified when the engine starts, unlike the single-service limitation in the before code.
                              Dynamic Subscription:
                              Handlers can be added or removed at runtime (demonstrated by unsubscribing EmailNotification in the second StartEngine call).
                              This supports scenarios where notification needs change dynamically.
                              Testability:
                              Unit testing is easier because you can subscribe test handlers or mocks to the OnEngineStarted event without needing a concrete service.
                              Alignment with DelegateDemo:
                              The use of a delegate (NotificationHandler) and event (OnEngineStarted) fulfills the intent of the DelegateDemo namespace, making the code more idiomatic.
                              Extensibility:
                              New notification types can be added by creating methods with the delegate signature and subscribing them to the event, without modifying Car.
                              """;
    }