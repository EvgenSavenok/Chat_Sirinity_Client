   M S B A M L   `   `   `  ����O  KChat_Sirinity_Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Chat_Sirinity_Client.PagesChat_Sirinity_Client.Pages  5      M+clr-namespace:Chat_Sirinity_Client.ControlsChat_Sirinity_Client.Controls  5      0    *Chat_Sirinity_Client.Pages.ListOfChatsPage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:Chat_Sirinity_Client.Pages     5      @controls+clr-namespace:Chat_Sirinity_Client.Controls     5        N� Title$  ListOfChats��5	      $	��450��6   $	��800��6(    � 	Resources 5
         BackgroundBrush �� ImageSource  SidePanelBtnStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius �� Triggers	 P� Property
 P� Value��%d  &	        &	 6     �� 5   
   $" /images/emoji-background.png��6-   �� 5   
   " ��6*   .�5      ��  � ��
 �����6+   �� 5       � ��$ 10q�6(   �� 5       � ��$ 2q�60   �� 5       � ��
 ��ح�6,   �� 5       � ��$ 14(�6)   �� 5       � ��$
 Bold"�6+   �� 5       �@�Cursor$
 Hand��6'   �� 5       � ��$ 45��6'   �� 5       � ��
 ��ح�6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5   !   #��z��5   !   $ 0��5   !   ._�5      �� $��Center=�6/   $��Center=�5   /   5      5       5"       5#      P� 5$      	 �@J�IsMouseOver$

 True��61   . �5%      ��  � �� �#CCE5FF63   �� 5&       � ��
 �����63   �� 5'       � �� �#CCE5FF64   5(      5*      5+      .��5,      � ��5-   
   �� 5.       �� Color$ #CCE5FF��6    � ColumnDefinitions 50   
   �� 51      $��3* �6   �� 52      $��5* �6   .+�54   
   �� $��0��6   ._�55      � .+�56      �  57      �� 58      $
��0.2* �6+   �� 59      $��* �6+   .+�5=      � $��0��5>      
����ح� � RowDefinitions 5@      �� 5A      $
��Auto �6,   �� 5B      $��* �6,   .+�5D      �� $��0��6%    �� Orientation$ Vertical=�62   .+�5E      �� #��[ 6%   .��5F   "   �� $&�� /Images/SidePanelIcons/chats.png��6(   6T   5G      �� 5H      #��[ 6%   .��5I   "   �� $(��"/Images/SidePanelIcons/profile.png��6(   6V   5J      �� 5K      #��[ 6%   $��
0, 7, 0, 0q�5L   %   .��5M   "   �� $)��#/Images/SidePanelIcons/settings.png��6(   6W   5N      5O      5P      � 5S      $��1��6   
�������.+�5T      �� 
�������$��	0 0 0.2 0q�64   ._�5U      0   *Chat_Sirinity_Client.Pages.SideMenuControl  .��5V   "   3   -Chat_Sirinity_Client.Controls.ChatListControl  5W      5X      5Y      5[      5\      5]       � 5^   
   -   5          �Name$ MainChatFrame��5^       $��1��6   6    5b      5c      