   M S B A M L   `   `   `  ����   Chat_Sirinity_Client-    'Chat_Sirinity_Client.Pages.RegisterPage   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008       N� Title$  RegisterPage��$	��450��$	��800�� � 	Resources    BackgroundBrush �� ImageSource  GradientStyle �� 
StartPoint �� EndPoint � Color � Offset  CustomButtonStyle �� 
TargetType �� Property	 �� Value
 �� 
TargetType ��Name �� CornerRadius �� Triggers P� Property P� Value �� 
TargetName  UnderlineLabel �� Triggers��%H  &	        &	 (     &	      7  &	 v    �� $" /images/emoji-background.png���� $ 0.5,1&�$ 0.5,0&�.��� $ 	LightBlue��$ 0Q�� $ Yellow��$ 1Q��� " ��.���  � ��8	   ��  � ��$	 0q���  � ��	 �� "
 ��.R��� $ border��#��z��#��z��#��z��$ 5��._��� $��Center=�$��Center=� P�  �@J�IsMouseOver$
 True��. ��� $ border�� � ��	 �#CCE5FF�� " ��.���  � ��	 �#c49a1a��  � ��	 �� "
 ��.R��� #��z��$��	Underline{� P�  �@J�IsMouseOver$
 True��. ���  � ��
	 ��  �.��� ����  �� Color$ #CCE5FF��.+�� #��[   � RowDefinitions �� $
��0.4* ��� $
��0.8* ��� $
��0.5* �.+�� $��0��$��Center=�.+��� $��Регистрация��$��Center=�$��29(����#c49a1a$��Segoe UI)� �� Padding$ 0, 30, 0, 0q��� 
�������$ 10�� �� Padding$ 10q�$	��350��$��Center=�$��Center=�$��1��._��� .+��  � ColumnDefinitions �� $��1.03* ��� $
��0.8* �.+��� $��0��$&�� Придумайте логин:�����#c49a1a$��Segoe UI)�$��18(��� -    ��Name$ LoginTb��$��1��$��16(�$
��Auto��$��24��.���  �� $��1.03* ��� $
��0.8* �.+��� $��0��$(��"Придумайте пароль:�����#c49a1a$��Segoe UI)�$��18(��� -   $ 
PasswordTb��$��1��$��16(�$
��Auto��$��24��.���  �� $��1.03* ��� $
��0.8* �.+��� $��0��$*��$Подтвердите пароль:�����#c49a1a$��Segoe UI)�$��18(��� -   $ ConfirmPasswordTb��$��1��$��16(�$
��Auto��$��24��.���  �� $��1.03* ��� $
��0.8* �.+��� $��0��$ ��Введите почту:�����#c49a1a$��Segoe UI)�$��18(��� -   $ EnterEmailTb��$��1��$��16(�$
��Auto��$��24��.��� .+��� -   $��0, 10, 0, 0q�$*��$Зарегистрироваться��$��18(�$��40��$
��Auto��#��[ � $��2��$
��Left=�.+��� -   $��На главную��$��Segoe UI)�$��Center=�$��Center=�$��40, 0 , 0, 30q�$��24(�#��[ 