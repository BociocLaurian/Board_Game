   M S B A M L   `   `   `  ����E  ABattleGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BattleGame
BattleGame  5   	        BattleGame.LobbyGameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BattleGame     5   	   -   5          �Name$  _Root��5	   	    � Title$ Lobby��5   	   $	��750��6   $	��800��6$    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	   ��5      �� 5   
    �� ImageSource$% Resources/Images/lobbyBkg2.jpeg��6   6E    � 	Resources 5         LabelDescriptionStyle �� Property �� Value  LabelDescriptionNames  ButtonStyle �� 
StartPoint	 �� EndPoint
 � Color � Offset �� 
TargetType  ButtonSetup  
ImageSetup  TextBoxSetup&   System.Windows.Media.TextOptions��%�  &	        &	 �     &	 g    &	 8    &	 �    &	 �    �� 5   
   .�5      ��  � ��$ 	Helvetica)�63   �� 5       � ��$ 15(�61   �� 5       � ��$
 Bold"�63   5      �� 5   
   .�5      ��  � ��$ 	Helvetica)�63   �� 5       � ��$ 24(�61   �� 5       � ��$
 Bold"�63   �� 5       � ��$	 Top=�6:   �� 5       � ��$ 40��6/   5      �� 5!   
   $ 0.5,0&�62   $	 0.5,1&�6E   .��5"      � $
 
WhiteSmoke��6   $ 0Q�6.   � 5#      $
 	SlateGray��6   $ 1Q�6-   � 5$      $
 	LightGray��6   $ 0.274Q�6-   5%      �� 5'   
   " ��6   .�5(      ��  � ��$ 2q�60   �� 5)       � ��$
 Bold"�6+   �� 5*       � ��$	 Top=�62   5+      �� 5-   
   " ��6   .�5.      ��  � ��$ UniformToFill=�6(   �� 5/       �@��BitmapScalingMode$ HighQuality=�6@   �� 50       � ��$	 140��6/   �� 51       � ��$	 120��6.   �� 52       � ��$	 Top=�62   53      �� 55   
   " ��6   .�56      ��  �@ TextFormattingMode$ Display=�6?   �� 57       �@��TextWrapping$ WrapWithOverflow=�6-   �� 58       � ��$ Arial)�63   �� 59       � ��$ 18(�61   �� 5:       � ��$
 Bold"�63   �� 5;       �@��TextAlignment$ Center=�68   �� 5<       �@^�ToolTip$ Enter your name here��67   �� 5=       � ��$ 25��6/   �� 5>       � ��$	 160��6.   �� 5?       � ��$	 Top=�6<   5@      5B      .��5D   
   � $��5q�6   .+�5F   
   �� $��Center=�6   $	��600��62   $��0,0,0,0q�6?   $	��500��6Q   $��Center=�6]   
�������.+�5H      �� -   5         ��Name$ GameName��5H      $�� ��6&   $��Center=�61   $��0,10,0,0q�6N   $	��Top=�6`   $	��237��6x   $��55��6�   $
��Bold"�6�   $��35(�6�   
���   �
���   �6�   �� 5I      -   5        $ Player1RedSide��5I      $�� ��6,   $
��Left=�67   $��	77,45,0,0q�6R   ���	#FFD10505#��[ 6|   �� 5J      -   5        $ Player2BlueSide��5J      $�� ��6-   $��Right=�68   $��
0,-40,73,0q�6T   ���	#FF061EB6#��[ 6   �� 5K      -   5        $ Player1RedSidelbl��5K      $�� ��6/   $
��Left=�6:   $��
78,145,0,0q�6U   $��1q�6i   $	��Top=�6u   #��[  6�   �� 5L      -   5        $ Player2BlueSidelbl��5L      $�� ��60   $��Right=�6;   $��
0,-20,78,0q�6W   $��1q�6k   $	��Top=�6w   #��[  6�   �� 5M      -   5         ��Name$ 
RedSideImg��5M      $<��6pack://application:,,,/Resources/Images/redSideImg.jpg��6(   $
��Left=�6i   $��70,-165,0,0q�6�   #��[ 6�   �� 5N      -   5        $ BlueSideImg��5N      $=��7pack://application:,,,/Resources/Images/blueSideImg.jpg��6)   $��Right=�6j   $��0,-165,70,0q�6�   #��[ 6�   �� 5O      -	   5         ��Name$ Player1RedNametxtbox��5O      $
��Left=�64   $��	50,10,0,0q�6O   $�� ��6b   #��[ 6j   �� 5P      -
   5        $ Player2BlueNametxtbox��5P      $��Right=�65   $��
0,-25,50,0q�6Q   $�� ��6e   #��[ 6m   �� 5Q      -   5         ��Name$ ChooseGameDifficultyText��5Q      $��26��6;   $
��Wrap=�6G    �� TextAlignment$ Center=�6[   $�� ��6s   $	��Top=�6{   $��Center=�6�   $��0,25,0,0q�6�   $	��476��6�   #��[  6�   �� 5R      -   5         ��Name$ cmbBoxDifficulty��5R      #��[ 6m    �� SelectedValuePath$	 Key��6�    �� DisplayMemberPath$ Value��6�   $��Center=�6�   $��150,5,150,0q�5S      $	��Top=�60   $	��190��6H   $��15(�6U   $
��Bold"�6c   $��Center=�6u   ��5R   1   ��  �� ElementName$ _Root�� �� Path$ GameOptions�5T      �� 5U      -   5         ��Name$ InstructionBtn��5U      $�� ��6-   $��	0,40,35,0q�69   $	��100��6M   $��Right=�6w   $��35��6�   
���   �$��16(�6�   #��[ 6�   #��[ 6�   �� 5V      -   5        $ StartBtn��5V      $�� ��6'   $��
40,25,40,0q�63   $	��120��6H   $��40��6T   $��18(�6|   
���� ��#��[ 6�   #��[ 6�   �� 5W      -   5        $ extraTextPage��5W      $�� ��6,   $��35,-100,0,0q�68   $	��100��6N   $��35��6\   $
��Left=�6h   
���   �$��16(�6�   #��[ 6�   #��[ 6�   6�   �� 5X      $	��100��6   5Y      5[      5\      