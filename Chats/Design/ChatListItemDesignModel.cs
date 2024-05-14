using System.Windows.Media;

namespace Chat_Sirinity_Client.Chats.Design;

public class ChatListItemDesignModel : ChatListItemViewModel
{
    #region Singleton

    public static ChatListItemDesignModel DesignInstance => new();

    #endregion

    #region Constructor

    public ChatListItemDesignModel()
    {
        Initial = "LM";
        Name = "Luke";
        Message = "This chat is amazing!";
        ProfilePictureRGB = "3099c5";
    }

    #endregion
}
