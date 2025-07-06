public class Logger
{
    public void LogButtonClick(object sender, ButtonClickedEventArgs e)
    {
        Console.WriteLine($"📝 Log: {e.ButtonName} clicked at {e.ClickedAt}");
    }
}