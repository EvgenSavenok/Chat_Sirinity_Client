using System.Windows.Media;
using Chat_Sirinity_Client.Chats;

namespace Chat_Sirinity_Client.Chats.InputChatMessage.MessageDesign;

public class ChatMessageListDesignModel : ChatMessageListViewModel
{
    #region Singleton

    public static ChatMessageListDesignModel DesignInstance => new();

    #endregion

    #region Constructor

    private void CreateChats()
    {
        Items = new List<ChatMessageListItemViewModel>()
        {
            new ChatMessageListItemViewModel()
            {
                SenderName = "Lera",
                Message = "Hello",
                Initial = "L",
                SentByMe = false,
                ProfilePictureRGB = "3099c5"
            },
            new ChatMessageListItemViewModel()
            {
                SenderName = "Eugen",
                Initial = "E",
                Message = "Hello, Lera",
                SentByMe = true,
                ProfilePictureRGB = "16c432"
            },
            new ChatMessageListItemViewModel()
            {
                SenderName = "Lera",
                Message = "How are u?",
                Initial = "L",
                SentByMe = false,
                ProfilePictureRGB = "3099c5"
            }
        };
    }

    public ChatMessageListDesignModel()
    {
        CreateChats();
    }

    #endregion
}
