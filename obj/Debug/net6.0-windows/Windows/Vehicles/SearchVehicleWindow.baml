   M S B A M L   `   `   `  ����R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:IntercityTransportation.Windows.Vehicles(IntercityTransportation.Windows.Vehicles  5   	   B    <IntercityTransportation.Windows.Vehicles.SearchVehicleWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:IntercityTransportation.Windows.Vehicles     5   	     � Title$!  Поиск автобуса��5   	   $	��450��6    $	��800��6-   .��5	      �� $��1��6    �� Orientation$ Vertical=�6   $��10q�65   .+�5
   
   �� $ 
Horizontal=�6   .+�5      �� $��
Поиск��6   $��Center=�6$   $��50��6?   �� 5      -   5         ��Name$ SearchTextBox��5      $
��Left=�6-    �� TextWrapping$
 Wrap=�6H   $��20��6\   $��Center=�5   "   $	��300��6=   �� 5      -   5         ��Name$ SearchVehicleButton��5      $��Искать��62   $	��100��6e   $��20��6q   $��10 0 0 0q�6}    � Cursor$
 Hand��6�   5      �� 5   
   .+�5      � -   5         �Name$ VehicleGridItem��5      $	��355��6.   $��0 10 0 0q�6<    � RowDefinitions 5      �� 5      $��0.90* �6$   65   �� 5      $��0.10* �6$   65    � ColumnDefinitions 5      .+�5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 VehicleGrid��5      
   
IsReadOnly$

 True��60      AutoGenerateColumns$ False��6B      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Марка��6L      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *
Brand.Name+6[     5      $ Модель��6G   $ * 6W    6-   �� *Model+6W     5      $ Гос. номер��6R   $ * 6f    6-   �� *GovernmentNumber+6f     5      $# Количество мест��6K   $ * 6d    6-   �� *	SeatCount+6d     5       $ Год ремонта��6L   $ * 6a    6-   �� *
RepairYear+6a     5!      $ Год выпуска��6M   $ * 6b    6-   �� *ReleaseYear+6b     5"      $ Пробег��6I   $ * 6Y    6-   �� *	Mileage+6Y   5$      �� 5%      $��1��6   $ 
Horizontal=�6*   .+�5&      �� -   5        $ ChoiseVehicleButton��5&      $��Выбрать��6:   $	��100��6n   $��20��6z   $��0 10 0 0q�6�   $
 Hand��6�   5'      5(      5)      5*      5+      