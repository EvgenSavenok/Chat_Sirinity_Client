using System.Windows.Media;

namespace Chat_Sirinity_Client.Chats.Design;

public class ChatListDesignModel : ChatListViewModel
{
    #region Singleton

    public static ChatListDesignModel DesignInstance => new();

    #endregion

    #region Constructor

    public ChatListDesignModel()
    {
        Items = new List<ChatListItemViewModel>
        {
            new ChatListItemViewModel
            {
                Name = "Luke",
                Initial = "L",
                Message = "This chat is amazing!",
                ProfilePictureRGB = "3099c5",
                IsSelected = true
            },
            new ChatListItemViewModel
            {
                Name = "Jessie",
                Initial = "J",
                Message = "Hey, dude!",
                ProfilePictureRGB = "fe4503"
            },
            new ChatListItemViewModel
            {
                Name = "Luke",
                Initial = "L",
                Message = "This chat is amazing!",
                ProfilePictureRGB = "3099c5"
            },
            new ChatListItemViewModel
            {
                Name = "Eugesha",
                Initial = "E",
                Message = "Hi!",
                ProfilePictureRGB = "00d405"
            },
            new ChatListItemViewModel
            {
                Name = "Jessie",
                Initial = "J",
                Message = "Hey, dude!",
                ProfilePictureRGB = "fe4503"
            },
            new ChatListItemViewModel
            {
                Name = "Luke",
                Initial = "L",
                Message = "This chat is amazing!",
                ProfilePictureRGB = "3099c5"
            },
            new ChatListItemViewModel
            {
                Name = "Jessie",
                Initial = "J",
                Message = "Hey, dude!",
                ProfilePictureRGB = "fe4503"
            },
            new ChatListItemViewModel
            {
                Name = "Eugesha",
                Initial = "E",
                Message = "Hi!",
                ProfilePictureRGB = "00d405"
            },
            new ChatListItemViewModel
            {
                Name = "Luke",
                Initial = "L",
                Message = "This chat is amazing!",
                ProfilePictureRGB = "3099c5"
            },
            new ChatListItemViewModel
            {
                Name = "Eugesha",
                Initial = "E",
                Message = "Hi!",
                ProfilePictureRGB = "00d405"
            },
            new ChatListItemViewModel
            {
                Name = "Jessie",
                Initial = "J",
                Message = "Hey, dude!",
                ProfilePictureRGB = "fe4503"
            },
            new ChatListItemViewModel
            {
                Name = "Luke",
                Initial = "L",
                Message = "This chat is amazing!",
                ProfilePictureRGB = "3099c5"
            },
            new ChatListItemViewModel
            {
                Name = "Eugesha",
                Initial = "E",
                Message = "Hi!",
                ProfilePictureRGB = "00d405"
            },
            new ChatListItemViewModel
            {
                Name = "Jessie",
                Initial = "J",
                Message = "Hey, dude!",
                ProfilePictureRGB = "fe4503"
            },
            new ChatListItemViewModel
            {
                Name = "Eugesha",
                Initial = "E",
                Message = "Hi!",
                ProfilePictureRGB = "00d405"
            }
        };
    }

    #endregion
}
