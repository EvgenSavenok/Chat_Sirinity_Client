using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;
using Chat_Sirinity_Client.Authentication;
using Chat_Sirinity_Client.Pages;
using Chat_Sirinity_Client;

namespace Chat_Sirinity_Client.Tools;

public class TCP
{
    public static string Name { get; set; }
    public static string Password { get; set; }
    private void StartConnection(string login, string password, Frame mainFrame, LoginPage loginWindow)
    {
        Name = login;
        Password = password;
        IPEndPoint remoteEndPoint;
        Socket clientSocket;
        try
        {
            remoteEndPoint = new IPEndPoint(IPAddress.Parse(Broadcast.ServerIpAddress), Broadcast.Port);
            clientSocket = new Socket(remoteEndPoint.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(remoteEndPoint);
            CustomAuthentication authentication = new();
            authentication.TryLoginUser(Name, Password, clientSocket);
            if (CustomAuthentication.IsLoginSuccessful)
            {
                mainFrame.Content = new ListOfChats();
                loginWindow.SetErrorLabelVisibility(Visibility.Collapsed);
            }
            else
            {
                loginWindow.SetErrorLabelVisibility(Visibility.Visible);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("Ошибка подключения к серверу. Попробуйте войти в чат позже. Ошибка: " +
                            e.Message);
        }
    }

    public void ConnectToChat(string login, string password, Frame mainFrame, LoginPage loginWindow)
    { 
        StartConnection(login, password, mainFrame, loginWindow);
    }
}
