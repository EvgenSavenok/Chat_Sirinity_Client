using System.Windows;
using System.Windows.Input;
using System.Windows.Media.TextFormatting;

namespace Chat_Sirinity_Client.Chats;

public class ChatMessageListViewModel
{
    public static List<ChatMessageListItemViewModel> Items { get; set; }

    public ICommand SendCommand { get; set; }

    public ChatMessageListViewModel()
    {
       SendCommand = new RelayCommand(Send);
    }
    
    public void Send()
    {
        MessageBox.Show("Sent!");
    }
}
