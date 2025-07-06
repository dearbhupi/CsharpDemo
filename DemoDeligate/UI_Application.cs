using System;
using System.Windows.Forms;

public class MainForm : Form
{
    private Button clickButton;
    private UIController controller;
    private Logger logger;

    public MainForm()
    {
        // Setup UI
        clickButton = new Button() { Text = "Click Me", Width = 100, Top = 30, Left = 50 };
        this.Controls.Add(clickButton);

        // Setup business logic
        controller = new UIController();
        logger = new Logger();

        // Subscribe to the event
        controller.ButtonClicked += logger.LogButtonClick;

        // Handle actual WinForms button click
        clickButton.Click += (s, e) => controller.SimulateButtonClick("Click Me");
    }
}