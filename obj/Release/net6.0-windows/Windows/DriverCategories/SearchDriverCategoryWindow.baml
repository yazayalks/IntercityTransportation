   M S B A M L   `   `   `  ���� R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:IntercityTransportation.Windows.DriverCategories0IntercityTransportation.Windows.DriverCategories  Q    KIntercityTransportation.Windows.DriverCategories.SearchDriverCategoryWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Plocal>clr-namespace:IntercityTransportation.Windows.DriverCategories       � Title$#  Поиск категории��$	��450��$	��800��.���� $��1�� �� Orientation$ Vertical=�$��10q�.+��� $ 
Horizontal=�.+��� $��
Поиск��$��Center=�$��50���� -    ��Name$ SearchTextBox��$
��Left=� �� TextWrapping$
 Wrap=�$��20��$��Center=�$	��300���� -    ��Name$  SearchDriverCategoryButton��$��Искать��$	��100��$��20��$��10 0 0 0q� � Cursor$
 Hand���� .+�� -    �Name$ DriverCategoryGridItem��$	��355��$��0 10 0 0q� � RowDefinitions �� $��0.90* ��� $��0.10* � � ColumnDefinitions .+�&   System.Windows.Controls.DataGrid  -   	  Name$	 DriverCategoryGrid��
   
IsReadOnly$

 True��   AutoGenerateColumns$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$) #Название категории��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Category+�� $��1��$ 
Horizontal=�.+��� -   $! ChoiseDriverCategorytButton��$��Выбрать��$	��100��$��20��$��0 10 0 0q�$
 Hand��