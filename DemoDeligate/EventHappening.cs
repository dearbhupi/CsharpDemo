public class ButtonClickedEventArgs : EventArgs
{
    public string ButtonName { get; set; }
    public DateTime ClickedAt { get; set; }

    public ButtonClickedEventArgs(string buttonName)
    {
        ButtonName = buttonName;
        ClickedAt = DateTime.Now;
    }
}