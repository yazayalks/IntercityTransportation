   M S B A M L   `   `   `  ����R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:IntercityTransportation.Windows.Drivers'IntercityTransportation.Windows.Drivers  5   	   @    :IntercityTransportation.Windows.Drivers.SearchDriverWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:IntercityTransportation.Windows.Drivers     5   	     � Title$!  Поиск водителя��5   	   $	��450��6    $	��800��6-   .��5	      �� $��1��6    �� Orientation$ Vertical=�6   $��10q�65   .+�5
   
   �� $ 
Horizontal=�6   .+�5      �� $��
Поиск��6   $��Center=�6$   $��50��6?   �� 5      -   5         ��Name$ SearchTextBox��5      $
��Left=�6-    �� TextWrapping$
 Wrap=�6H   $��20��6\   $��Center=�5   "   $	��300��6=   �� 5      -   5         ��Name$ SearchDriverButton��5      $��Искать��61   $	��100��6c   $��20��6o   $��10 0 0 0q�6{    � Cursor$
 Hand��6�   5      �� 5   
   .+�5      � -   5         �Name$ DriverGridItem��5      $	��355��6-   $��0 10 0 0q�6;    � RowDefinitions 5      �� 5      $��0.90* �6$   65   �� 5      $��0.10* �6$   65    � ColumnDefinitions 5      .+�5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 
DriverGrid��5      
   
IsReadOnly$

 True��6/      AutoGenerateColumns$ False��6A      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6K      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *	FirstName+6X     5      $ Фамилия��6J   $ * 6[    6-   �� *
LastName+6[     5      $ Отчество��6L   $ * 6^    6-   �� *
MiddleName+6^     5      $ Дата рождения��6l   $ * 6�    6-   �� *	BirthDate+ �� StringFormat$ {0:dd/MM/yyyy}��6�     5       $ Категория��6Y   $ * 6l    6-   �� *DriverCategory.Category+6l     5!      $ 
Класс��6M   $ * 6\    6-   �� *DriverClass+6\     5"      $ Стаж��6P   $ * 6^    6-   �� *WorkExperience+6^   5$      �� 5%      $��1��6   $ 
Horizontal=�6*   .+�5&      �� -   5        $ ChoiseDriverButton��5&      $��Выбрать��69   $	��100��6l   $��20��6x   $��0 10 0 0q�6�   $
 Hand��6�   5'      5(      5)      5*      5+      