   M S B A M L   `   `   `  ����E  ABattleGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BattleGame
BattleGame  5   	   &     BattleGame.InstructionGameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:BattleGame     5   	     � Title$  Instruction��5   	   $	��750��6   $
��1100��6*    � WindowStartupLocation$ CenterOwner=�5	   	    � 
ResizeMode$ NoResize=�6-   ��5      �� 5   
    �� ImageSource$- '../Resources/Images/instrWindowBkg.jpeg��6   6M    � 	Resources 5         TextBlockSetup&   System.Windows.Media.TextOptions �� Property �� Value  TextBlockDescriptionText��%�  &	        &	 T    �� 5   
   .�5      ��  �@ TextFormattingMode$ Display=�6?   �� 5       � ��$ 	Helvetica)�63   �� 5       � ��$ 20(�61   �� 5       � ��$
 Bold"�63   �� 5       �@��TextAlignment$ Center=�68   �� 5       � ��$ Center=�6<   �� 5       � ��$ 	15,5,15,5q�61   5      �� 5   
   .�5      ��  � ��$ 	Helvetica)�63   �� 5       � ��$ 12(�61   �� 5       � ��$
 Bold"�63   5       5#      .��5%      � .+�5'   
   ��  �� Orientation$ 
Horizontal=�6   $��40��6/   $	��Top=�6;   $��Center=�6S   $��15,10,15,10q�6p   .+�5)      �� $��
HOW TO 101��6   $��Center=�6+   $��33(�6H   $��	ExtraBold"�6V   $��	Helvetica)�6m   $��5q�6�   
�������6�   5+      � 5.   
   
�������$��25,35,25,10q�6"   $	��615��67    � ColumnDefinitions 50      �� 51      $��* �6#   �� 52      $��* �6#   �� 53      $��2* �6#   �� 54      $��* �6#   	 � RowDefinitions	 58      �� 59      $
��0.5* �6    �� 5:      $��4* �6    .+�5>      �� $��0��6   $��0��6(   $��
Despre Joc��65   #��[  6G   �� 5?      -   5        
 ��Name$
 aboutGameDesc��5?      $��0��60   $��1��6@   $�� ��6M   $
��Wrap=�6U   $	��520��6j   $	��180��6w   #��[ 6�   �� 5A      $��1��6   $��0��6(   $��Fazele unei Ture ��65   #��[  6N   �� 5B      -   5        $
 	aboutTurn��5B      $��1��6,   $��1��6<   $�� ��6I   $
��Wrap=�6Q   $	��510��6e   $	��180��6r   #��[ 6   �� 5C      $@��:pack://application:,,,/Resources/Images/energyProcents.png��6   $	��100��6X   $	��100��6e   $��Bottom=�6q   $��0,0,0,25q�6�   $��1��6�   $��1��6�   �� 5E      $��2��6   $��0��6(   $��Efect Abilități��65   #��[  6L   �� 5F      -   5        $
 abilityTopText��5F      $��2��60   $��1��6@   $�� ��6M   $��82��6V   $	��Top=�6b   $��43,102,32,0q�6z   $
��Wrap=�6�   #��[ 6�   �� 5G      $>��8pack://application:,,,/Resources/Images/basicAbility.png��6   $��87��6V   $	��390��6b   $	��Top=�6n   $��
14,10,13,0q�6�   $��2��6�   $��1��6�   �� 5H      -   5        $
 abilityCenterText��5H      $��2��63   $��1��6C   $�� ��6P   $	��106��6Y   $��Center=�6f   $��323,428,24,13q�6�   $
��Wrap=�6�   #��[ 6�   $��2��6�   �� 5I      $C��=pack://application:,,,/Resources/Images/specialAbilityNr1.png��6   $	��239��6[   $��Center=�6h   $��281,184,10,124q�6�   $��2��6�   $��1��6�   $��2��6�   �� 5J      -   5        $
 abilityBottomText��5J      $��2��63   $��1��6C   $�� ��6P   $	��109��6Y   $��Bottom=�6f   $��15,0,108,10q�6�   $
��Wrap=�6�   #��[ 6�   �� 5K      $C��=pack://application:,,,/Resources/Images/specialAbilityNr2.png��6   $	��220��6[   $��Bottom=�6h   $��14,0,141,124q�6�   $��2��6�   $��1��6�   �� 5M      $��3��6   $��0��6(   $��Final de Joc��65   #��[  6I   �� 5N      -   5        $
 gameFinalText��5N      $��3��61   $��1��6A   $�� ��6N   $	��180��6V   $
��Wrap=�6b   #��[ 6v   $��15,11,14,378q�6�   5P      5Q      5R      