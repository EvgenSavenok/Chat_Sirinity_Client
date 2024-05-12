using System.Windows.Controls;

namespace Chat_Sirinity_Client.Pages;

public partial class RegisterPage : Page
{
    readonly Frame _mainFrame = MainWindow.MainFrameInstance;
    public RegisterPage()
    {
        InitializeComponent();
    }

    private void RegisterBtn_CLick(object sender, EventArgs e)
    {
        
    }

    private void BackToWelcomePageBtn_Click(object sender, EventArgs e)
    {
        _mainFrame.Content = new WelcomePage();
    }
}

