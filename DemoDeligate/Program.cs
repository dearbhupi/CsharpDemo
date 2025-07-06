using System;
using DeligateDemo;

namespace DelegateDemo // Note: "DeligateDemo" in your code seems to be a typo; corrected to "DelegateDemo"
{


    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of NotificationServices
            NotificationServices notificationServices = new NotificationServices();

            // Create an instance of Car, passing NotificationServices
            Car car = new Car(notificationServices);

            // Call the StartEngine method
            car.StartEngine();

            // Keep console open to view output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}