using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace Chat_Sirinity_Client;

public partial class MainWindow : Window
{
    public static Frame MainFrameInstance { get; set; }
    private const int Port = 8888;
    public MainWindow()
    {
        InitializeComponent();
        MainFrameInstance = MainFrame;
        MainFrame.Content = new WelcomePage();
    }

    private async void ConnectToServer()
    {
        try
        {
            UdpClient udpClient = new(Port);
            udpClient.EnableBroadcast = true;
            UdpReceiveResult receiveResult = await udpClient.ReceiveAsync();
            byte[] receiveBytes = receiveResult.Buffer;
            string receivedData = Encoding.UTF8.GetString(receiveBytes);
            udpClient.Close();
            Console.WriteLine($"Received broadcast from {receiveResult.RemoteEndPoint} : {receivedData}\n");
        }
        catch (Exception)
        {
            Console.WriteLine("Cannot connect to server.");
        }
    }
    private void OnLoad(object sender, RoutedEventArgs e)
    {
        ConnectToServer();
    }
}
