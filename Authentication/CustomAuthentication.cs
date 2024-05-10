using System.Net.Sockets;
using System.Text;
using System.Windows;

namespace Chat_Sirinity_Client.Authentication;

public class CustomAuthentication
{
    public static bool IsLoginSuccessful = false;
    private bool HandleAuthorizationAnswer(string answer)
    {
        string[] answerParts = answer.Split("\r\n");
        if (answerParts[1] == "ok" && answerParts.Length == 2)
            return true;
        if (answerParts[1] == "fail")
            return false;
        return false;
    }
    private void GetMessage(Socket clientSocket)
    {
        try
        {
            byte[] buffer = new byte[1024];
            int numOfBytes = clientSocket.Receive(buffer);
            string receivedMessage = Encoding.UTF8.GetString(buffer, 0, numOfBytes);
            if (HandleAuthorizationAnswer(receivedMessage))
                IsLoginSuccessful = true;
            else
                IsLoginSuccessful = false;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка соединения");
        }
    }
    public void TryLoginUser(string login, string password, Socket clientSocket)
    {
        string loginMessage = $"login\r\n{login}\r\n{password}";
        byte[] nameBuffer = Encoding.UTF8.GetBytes(loginMessage);
        clientSocket.Send(nameBuffer);
        GetMessage(clientSocket);
    }
}
