using System;

public class AlarmSystem
{
    // Step 1: Define a delegate (optional with EventHandler pattern)
    public delegate void AlarmEventHandler(string message);

    // Step 2: Declare an event using the delegate
    public event AlarmEventHandler OnAlarmTriggered;

    public void TriggerAlarm()
    {
        Console.WriteLine("🚨 Alarm triggered!");
        // Step 3: Raise the event (notify subscribers)
        //OnAlarmTriggered?.Invoke("Fire detected in Sector 7G!");
        if (OnAlarmTriggered != null)
            OnAlarmTriggered("Fire detected on Sector 13");
    }
}