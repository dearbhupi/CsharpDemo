namespace DemoDeligate;

public class Program
{
    public static void Main()
    {
        AlarmSystem alarm = new AlarmSystem();
        SecurityTeam security = new SecurityTeam();

        // Subscribe the Respond method to the alarm event
        alarm.OnAlarmTriggered += security.Respond;
        alarm.OnAlarmTriggered += security.FireDeptartment;

        // Trigger the alarm (calls all subscribed methods)
        alarm.TriggerAlarm();
    }
}