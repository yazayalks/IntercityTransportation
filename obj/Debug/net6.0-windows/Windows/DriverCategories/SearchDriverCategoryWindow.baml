   M S B A M L   `   `   `  ����R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:IntercityTransportation.Windows.DriverCategories0IntercityTransportation.Windows.DriverCategories  5   	   Q    KIntercityTransportation.Windows.DriverCategories.SearchDriverCategoryWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Plocal>clr-namespace:IntercityTransportation.Windows.DriverCategories     5   	     � Title$#  Поиск категории��5   	   $	��450��6!   $	��800��6.   .��5	      �� $��1��6    �� Orientation$ Vertical=�6   $��10q�65   .+�5
   
   �� $ 
Horizontal=�6   .+�5      �� $��
Поиск��6   $��Center=�6$   $��50��6?   �� 5      -   5         ��Name$ SearchTextBox��5      $
��Left=�6-    �� TextWrapping$
 Wrap=�6H   $��20��6\   $��Center=�5   "   $	��300��6=   �� 5      -   5         ��Name$  SearchDriverCategoryButton��5      $��Искать��69   $	��100��6s   $��20��6   $��10 0 0 0q�6�    � Cursor$
 Hand��6�   5      �� 5   
   .+�5      � -   5         �Name$ DriverCategoryGridItem��5      $	��355��65   $��0 10 0 0q�6C    � RowDefinitions 5      �� 5      $��0.90* �6$   65   �� 5      $��0.10* �6$   65    � ColumnDefinitions 5      .+�5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 DriverCategoryGrid��5      
   
IsReadOnly$

 True��67      AutoGenerateColumns$ False��6I      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$) #Название категории��6J      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *
Category+6f   5      �� 5      $��1��6   $ 
Horizontal=�6*   .+�5       �� -   5        $! ChoiseDriverCategorytButton��5       $��Выбрать��6B   $	��100��6}   $��20��6�   $��0 10 0 0q�6�   $
 Hand��6�   5!      5"      5#      5$      5%      