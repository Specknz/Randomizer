   M S B A M L   `   `   `  ����E  ARandomizer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Randomizer.ViewsRandomizer.Views  5          Randomizer.Views.MainView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:Randomizer.Views     5      
�������.��5
      � .+�5   
   �   � ColumnDefinitions  5      �� 5      $��10 �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $
��auto �6#   �� 5      $��* �6#   �� 5      $��10 �6#    � RowDefinitions 5      �� 5      $��10 �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $��* �6    �� 5      $��10 �6    .+�5       ��  �� Orientation$ Vertical=�6   $��1��5!      $��1��5"      $��4��5#      .+�5%      �� $��Lists:��6   $��20(�5&      $
��Bold"�5'      �� 5*      
���   �$��1q�5+      ._�5,      �� ��6#   �� *ListDataSelectors+��5-      �� 5.      .R�5/   "   �  � Orientation$ 
Horizontal=�6,   
�������50   (   51      ��53      �� 54      .R�55   "   ��  ��Name$ 
isSelected��6+   $��5q�58   '   ��56   '   �� *Name+ d� 	IsChecked 57   '   �� *
IsSelected+58   '   59      5;      5<      5=      �� 5?      $��3��6   $��1��5@      $��4��5A      ._�5B      �� ��6   �� *ListDataDisplayItems+��5C      �� 5D      .R�5E      � $ 
Horizontal=�6(   5F      ��5H      �� 5I      .R�5J      �� $��0 2 0 2q�6)   .+�5K   "   �� 
���   �$��0 0 0 1q�5L   %   ._�5M   &   �� ��6,   �� *Name+5N   #   �� 5O   "   $��0q�5P   '   ��5O   +   �� *Items+��5Q   &   �� 5R   *   .R�5S   .   �� ��68   �� 5T   +   5V   #   5W      5X      5Z      5[      �� 5]      $��5��6   $��1��5^      $��Allow Duplicates��5_      $��5 5 5 5q�5a      $
��Left=�5b      $��Bottom=�5c       5`      ��  �� Path$ AllowDuplicateListItems�5c      �� 5e      $ 
Horizontal=�6   $��5��5f      $��2��5g      $��Center=�5h      $��Bottom=�5i      .+�5j      �� $��Number of Items:��6   $��5 5 0 0q�5k      $��Center=�5l      �� 5m      $��35��6   $��18��5n      $��0 5 5 0q�5o      $��Center=�5p      $��Center=�5q      ��5r      �� *NumberOfListItemsToDisplay+5s      �� 5u      $��5��5v      $��4��5w      $��Generate��5x      $��75��5y      $	��100��5z      $��Right=�5{      $��Bottom=�5|      $��5 5 5 5q�5}      ��5u      �� *GenerateData+5}      5~      5      5�      