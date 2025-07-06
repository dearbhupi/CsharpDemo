using System;
using DeligateDemo;
using DemoDeligate;

namespace DelegateDemo // Note: "DeligateDemo" in your code seems to be a typo; corrected to "DelegateDemo"
{


    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of NotificationServices
            NotificationInterface.INotificationService smsNotify = new SMSNotificationServices();
            
            NotificationInterface.INotificationService emailNotify = new SMSNotificationServices();

            // Create an instance of Car, passing NotificationServices
            Car car = new Car(smsNotify);
            Car car2 = new Car(smsNotify);

            // Call the StartEngine method
            car.StartEngine();
            car2.StartEngine();

            // Keep console open to view output
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
    
}