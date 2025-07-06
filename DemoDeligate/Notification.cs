public class UIController
{
    // Declare the event using EventHandler<T>
    public event EventHandler<ButtonClickedEventArgs> ButtonClicked;

    public void SimulateButtonClick(string buttonName)
    {
        Console.WriteLine($"🔘 {buttonName} button clicked!");

        // Raise the event
        ButtonClicked?.Invoke(this, new ButtonClickedEventArgs(buttonName));
    }
}