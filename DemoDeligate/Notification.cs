using System;

public class Button
{
    // Declare an event using a delegate
    public event Action OnClick;

    public void Click()
    {
        Console.WriteLine("🔘 Button clicked.");
        //OnClick?.Invoke(); // Call all subscribed methods
        if (OnClick != null)
            OnClick();
    }
}

public class Program
{
    public static void ShowAlert()
    {
        Console.WriteLine("⚠️ Alert: Button was clicked!");
    }

    public static void LogClick()
    {
        Console.WriteLine("📝 Log: Click event registered.");
    }

    public static void Main()
    {
        Button btn = new Button();

        // Subscribe multiple methods to the button's click event
        btn.OnClick += ShowAlert;
        btn.OnClick += LogClick;

        // Simulate button click
        btn.Click();
    }
}