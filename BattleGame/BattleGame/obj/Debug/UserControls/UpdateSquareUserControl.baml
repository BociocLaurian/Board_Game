   M S B A M L   `   `   `  ����E  ABattleGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:BattleGame.UserControlsBattleGame.UserControls  5   	   0    *BattleGame.UserControls.UpdateChosenSquare   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:BattleGame.UserControls     5   	     � Title$  UpdateChosenSquare��5   	   $	��260��6$   $	��300��61    � WindowStartupLocation$ CenterScreen=�6=    � 
ResizeMode$ NoResize=�6d   .��5
      � 
�������.+�5   
   �� -   5         ��Name$ Position��5      $
��Left=�6&   $��5 5 0 0q�6A   $
��Bold"�6R   $��15(�6d   6t   �� 5   
   -   5         ��Name$ AbilityText��5      $��Center=�6%   $��	55 10 0 0q�6B   $
��Bold"�6U   $��17(�6g   �� 5   
   -   5        $ HighEnergyCostLabel��5      $��1 X HE ��6-   $
��Left=�6?   $��	19 49 0 0q�6[   $
��Bold"�6n   $��14(�6�   �� 5   
   -   5        $ MediumEnergyCostLabel��5      $��1 X ME ��6/   $��Center=�6A   $��1 49 0 0q�6_   $
��Bold"�6q   $��14(�6�   �� 5   
   -   5        $ LowEnergyCostLabel��5      $��1 X LE��6,   $��Right=�6=   $��	0 49 23 0q�6Z   $
��Bold"�6m   $��14(�6   � 5   
   $��Center=�6   $��0 0 0 10q�6*    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ HighLevelEnergy��5   %   $��0��6   $��Center=�6>   $��50��6[   $��50��6g   $��Black"�6s   $��20(�6�   5      �� 5       -   5        $ MediumLevelEnergy��5    &   $��1��6   $��Center=�6A   $��50��6^   $��50��6j   $��Black"�6v   $��20(�6�   5!      �� 5#      -   5        $ LowLevelEnergy��5#   %   $��2��6   $��Center=�6=   $��50��6Z   $��50��6f   $��Black"�6r   $��20(�6�   5$      5&      �� 5(   
   -	   5        $ SpecialAbillity1CostLabel��5(      $��1 X HE + 1 X ME��63   $
��Left=�6M   $��
30 150 0 0q�6i   $
��Bold"�6}   $��13(�6�   �� 5)   
   -
   5        $ SpecialAbillity2CostLabel��5)      $��2 X LE��63   $��Right=�6D   $��
0 150 62 0q�6a   $
��Bold"�6u   $��13(�6�   � 5+   
   $��Bottom=�6   $��
30 0 30 10q�6*    5-      �� 5.      $��* �6#   �� 5/      $��* �6#   .+�53      �� -   5        $ SpecialAbility1��53   '   $��0��6   $��Center=�6@   $��35��6]   $��90��6i   $�� ��6t   $��Black"�6   $��20(�6�   $��0,20,5,0q�6�   6�   �� 55      -   5        $ SpecialAbility2��55   %   $��1��6   $��Center=�6>   $��35��6[   $��90��6g   $�� ��6r   $��Black"�6}   $��20(�6�   $��5,20,0,0q�6�   6�   57      58      59      