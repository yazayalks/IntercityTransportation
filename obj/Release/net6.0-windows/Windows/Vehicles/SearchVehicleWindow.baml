   M S B A M L   `   `   `  ���� R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:IntercityTransportation.Windows.Vehicles(IntercityTransportation.Windows.Vehicles  B    <IntercityTransportation.Windows.Vehicles.SearchVehicleWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Hlocal6clr-namespace:IntercityTransportation.Windows.Vehicles       � Title$!  Поиск автобуса��$	��450��$	��800��.���� $��1�� �� Orientation$ Vertical=�$��10q�.+��� $ 
Horizontal=�.+��� $��
Поиск��$��Center=�$��50���� -    ��Name$ SearchTextBox��$
��Left=� �� TextWrapping$
 Wrap=�$��20��$��Center=�$	��300���� -    ��Name$ SearchVehicleButton��$��Искать��$	��100��$��20��$��10 0 0 0q� � Cursor$
 Hand���� .+�� -    �Name$ VehicleGridItem��$	��355��$��0 10 0 0q� � RowDefinitions �� $��0.90* ��� $��0.10* � � ColumnDefinitions .+�&   System.Windows.Controls.DataGrid  -   	  Name$	 VehicleGrid��
   
IsReadOnly$

 True��   AutoGenerateColumns$ False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Марка��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
Brand.Name+  $ Модель��$ *  �� *Model+  $ Гос. номер��$ *  �� *GovernmentNumber+  $# Количество мест��$ *  �� *	SeatCount+  $ Год ремонта��$ *  �� *
RepairYear+  $ Год выпуска��$ *  �� *ReleaseYear+  $ Пробег��$ *  �� *	Mileage+�� $��1��$ 
Horizontal=�.+��� -   $ ChoiseVehicleButton��$��Выбрать��$	��100��$��20��$��0 10 0 0q�$
 Hand��