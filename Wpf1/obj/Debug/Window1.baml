   M S B A M L   `   `   `  ����?  ;Wpf1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Wpf1Wpf1  5   	       Wpf1.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Wpf1     5   	     � Title$  Window1��5   	   $	��450��6   $	��800��6&   .��5	      � $��
0,0,-0.4,0q�6    � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� -   5        $��listP��5   T   $��0��63   $��5��6C   ��6   �� *
Contacts+5      �� 5   
   -   5        $��listMessage��5   y   $��1��6X   $��5��6h   ��6   ��  �� ElementName$ listP�� �� Path$ SelectedItem.Messages�5   
   �� 5    
   $��0��6   $��6��6!   $��10,10,140,10q�6.   .��6F   +6I   �� 5!   
   $��0��6   $��6��6!   $��140,10,10,10q�6.   ��6D   �� *removePersonneCommand+��6n   �� $ listP��$ SelectedItem�.��6�   -6�   �� 5"   
   -   5        $��
MessageBox��5"   ;   $��1��6   $��6��6"   $��12q�6/   ��6N   �� *	Message+ �� Mode$ TwoWay=�6u   �� 5#   
   $��3��6   $��6��6!   $��80,10,80,10q�6.   ��6C   �� *addMessageCommand+��6i   �� $ listP��$ SelectedItem�.��6�   Send6�   5%      5'      