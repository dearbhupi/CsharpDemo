using System;
//using DeligateDemo;
using DemoDeligate;

namespace DelegateDemo // Note: "DeligateDemo" in your code seems to be a typo; corrected to "DelegateDemo"
{


    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of NotificationServices
            // Subscribe to the event with different handlers
            
            // Create an instance of Car, passing NotificationServices
            Car car = new Car();
            
            car.OnNotification += message => Console.WriteLine($"SMS Notification: {message}");
            car.OnNotification += message => Console.WriteLine($"EmailNotification: {message} ");

            // Call the StartEngine method
            car.StartEngine();
           

            // Keep console open to view output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    
}