using System;

public class Notifications
{
    // Step 1: Define the delegate here the method defination 
    public delegate void Notify(string message);

    // Step 2: Define methods with matching signatures
    public static void SMSNotification(string message)
    {
        Console.WriteLine($"SMS Notification : {message}");
    }

    public static void EmailNotification(string message)
    {
        Console.WriteLine($"Email message : {message} ");
    }

    public static void Main()
    {
        // Step 3: Use the delegate to call different methods
        Notify ntf;

        ntf = SMSNotification;
        ntf("your OTP is 1234");  // Calls ItalianChef

        ntf = EmailNotification;
        ntf("your recipt number is 112233"); // Calls ChineseChef
    }
}