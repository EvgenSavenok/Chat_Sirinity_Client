using System.Windows.Controls;

namespace Chat_Sirinity_Client;

public partial class WelcomePage : Page
{
    Frame _mainFrame = MainWindow.MainFrameInstance;
    public WelcomePage()
    {
        InitializeComponent();
    }
    
    private void LoginBtn_Click(object sender, EventArgs e)
    {
        _mainFrame.Content = new LoginPage();
    }
}

