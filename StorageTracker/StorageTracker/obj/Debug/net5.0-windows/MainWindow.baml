   M S B A M L   `   `   `  ����I  EStorageTracker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:StorageTrackerStorageTracker  5   	       StorageTracker.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:StorageTracker     5   	   -   5          � Title$  Storage Manager��5   	   $	��620��5	   	   $	��650��6   
���P��.��5      ��  �� Orientation$ Vertical=�5   	   $��20q�5   	   .+�5   
   �� .+�5      � 
�������$	��600��5      $��40��5      .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6+   �� 5      $
��Auto �6+   .+�5      �� -   5         ��Name$ 	searchBox��5      $��20(�5      
�������$��0��5      $��5q�5      $��30��5!      $	��590��5"      .��6)   5#      5$      5%      �� 5'      
 �� Top$ 60��5(      .��5)      � $	��580��5*      $	��370��5+      .+�5-      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5-         AutoGenerateColumns$ False��5.      $y�Visible=�5/      ��50      �� *	itemsList+   Columns 51      4  .System.Windows.Controls.DataGridTemplateColumn  52      ,  &System.Windows.Controls.DataGridColumn   Header$ Select��65   	   CellTemplate	 53   "   �� 54   &   .R�55   *   �� -   5        $��Center=�59   -   
 d� 	IsChecked
 56   -   �� *	IsChecked+ �� Mode$ TwoWay=�5:   +   5;   '   5=      0  *System.Windows.Controls.DataGridTextColumn  5>      $
 Name��61      Width5  /System.Windows.Controls.DataGridLengthConverter$	 400 6X      
IsReadOnly$
 True��5?   1   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5>   ?   �� *Name+5?   1     5@      $ Quantity��61    6C   �� *
Quantity+  5A      $ PricePerUnit��61    6G   �� *PricePerUnit+5C      5D      5E      � 5G      $	 440��5H       � 	Resources 5I       �� 
TargetType �� Property �� Value��%�   '��       �� 5J      " ��6   .�5K      ��  � ��$	 100��62   �� 5L       � ��$ 30��63   �� 5M       � ��$ 15(�65   �� 5N       � ��$
 Bold"�67   �� 5O       � ��$ 3q�63   5P      5Q      .+�5R      �� -   5        $��
Select All��5R      5U      �� 5V      -   5        $��Deselect All��5V      5Y      5Z      � 5\      $	 500��5]       5^      ��%}  '��       �� 5_      " ��6   .�5`      ��  � ��
 �����67   �� 5a       � ��$ 10, 0q�65   �� 5b       � ��$ 15, 0q�63   �� 5c       � ��$ 2q�6<   �� 5d       � ��
 �   �68   �� 5e       � ��$ 33��64   �� 5f       � ��$ 75��63   �� 5g       � ��$ 17(�65   �� 5h       � ��$
 Bold"�67   5i      5j      .+�5l      �� -   5         ��Name$ 	addButton��5n      $
{�True��5m      $	��ADD��5o      5q      �� 5s      -   5        $ 	delButton��5t      $��DELETE��5u      $��90��6&   5w      �� 5y      -	   5        $ 
sellButton��5z      $
��SELL��5{      5}      5      5�      5�      5�      