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
    public static Socket ClientSocket { get; set; }
    
    private void StartConnection(string login, string password, Frame mainFrame, LoginPage? loginWindow, RegisterPage? registerWindow)
    {
        Name = login;
        Password = password;
        IPEndPoint remoteEndPoint;
        try
        {
            remoteEndPoint = new IPEndPoint(IPAddress.Parse(Broadcast.ServerIpAddress), Broadcast.Port);
            ClientSocket = new Socket(remoteEndPoint.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            ClientSocket.Connect(remoteEndPoint);
            CustomAuthentication authentication = new();
            authentication.DetermineTypeOfAuthentication(mainFrame, loginWindow, registerWindow);
        }
        catch (Exception e)
        {
            MessageBox.Show("Ошибка подключения к серверу. Попробуйте войти в чат позже. Ошибка: " +
                            e.Message);
        }
    }

    public void ConnectToChat(string login, string password, Frame mainFrame, LoginPage? loginWindow, RegisterPage? registerWindow)
    { 
        StartConnection(login, password, mainFrame, loginWindow, registerWindow);
    }
}
