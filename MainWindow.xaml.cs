using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Shapes;
using Chat_Sirinity_Client.Tools;

namespace Chat_Sirinity_Client;

public partial class MainWindow : Window
{
    public static Frame MainFrameInstance { get; set; }
    public MainWindow()
    {
        InitializeComponent();
        MainFrameInstance = MainFrame;
        MainFrame.Content = new WelcomePage();
    }
    protected override void OnSourceInitialized(EventArgs e)
    {
        IconHelper.RemoveIcon(this);
    }
    
    private void OnLoad(object sender, RoutedEventArgs e)
    {
        Broadcast broadcast = new Broadcast();
        broadcast.ConnectToServer();
    }
}
