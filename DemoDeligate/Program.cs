using System;
//using DeligateDemo;
using DemoDeligate;

namespace DelegateDemo // Note: "DeligateDemo" in your code seems to be a typo; corrected to "DelegateDemo"
{


    class Program
    {
        static void Main(string[] args)
        {
            // Create a Car instance
            Car car = new Car();

            // Subscribe multiple handlers to the OnEngineStarted event
            car.OnEngineStarted += NotificationServices.ConsoleNotification;
            car.OnEngineStarted += NotificationServices.EmailNotification;
            car.OnEngineStarted += NotificationServices.LogNotification;

            // Optionally, add an inline handler using a lambda
            car.OnEngineStarted += message => Console.WriteLine($"Inline Handler: {message}");

            // Start the engine, triggering all subscribed handlers
            car.StartEngine();

            Console.WriteLine("\n=== Demonstrating Unsubscribing ===");
            // Unsubscribe one handler to show flexibility
            car.OnEngineStarted -= NotificationServices.EmailNotification;
            car.StartEngine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}