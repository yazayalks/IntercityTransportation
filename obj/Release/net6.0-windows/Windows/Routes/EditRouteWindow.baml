   M S B A M L   `   `   `  ���� R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:IntercityTransportation.Windows.Routes&IntercityTransportation.Windows.Routes  <    6IntercityTransportation.Windows.Routes.EditRouteWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Flocal4clr-namespace:IntercityTransportation.Windows.Routes     ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit    � Title$3  -Редактирование маршрута��$	��450��$	��800��.����  �� Orientation$ 
Horizontal=�$��10 10 10 10q�.+��� $
��Auto��.+��� $ 
Horizontal=�$��0 5 0 0q�.+��� $#��Начальный пункт��$
��Left=�$��Center=�$	��160���� -    ��Name$ StartingPointTextBox�� �� TextWrapping$
 Wrap=� �� 
IsReadOnly$
 True��$��Center=�$	��120��$��20�� � Cursor$ Arrow������  �� Path$ Route.StartingPoint.Name��� -   $2��,Выбрать начальный пункт��$	��160��$��20��$��	10 0 10 0q�$
 Hand���� $ 
Horizontal=�$��0 5 0 0q�.+��� $!��Конечный пункт��$
��Left=�$��Center=�$	��160���� -   $ EndingPointTextBox��$
 Wrap=�$
 True��$��Center=�$	��120��$��20��$ Arrow������ $ Route.EndingPoint.Name��� -   $0��*Выбрать конечный пункт��$	��160��$��20��$��	10 0 10 0q�$
 Hand���� $ 
Horizontal=�$��0 5 0 0q�.+��� $'��!Время отправления��$
��Left=�$��Center=�$	��160��"  Xceed.Wpf.Toolkit.TimePicker  -   $��DepartureTimePicker��$	��120��,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text �� $ Route.DepartureTime��� $$��Часы : минуты: AM/PM��$��Center=�$��Center=�$	��160��$��	10 0 10 0q��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Время в пути��$
��Left=�$��Center=�$	��160��  -   $��TravelTimePicker��$	��120��&   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�	   FormatString$	 d:HH:mm�� �� $ Route.TravelTime��� $&�� Дни : часы : минуты��$��Center=�$��Center=�$	��160��$��	10 0 10 0q��� -   $��Сохранить��$��Center=�$	��120��$��20��$��-10 10 10 0q�$
 Hand���� $
��Auto��$��Center=�$��20 0 0 0q�.+��� .��Остановки&   System.Windows.Controls.DataGrid  -   
  Name$
 BusStopGrid��   AutoGenerateColumns$ False��   
IsReadOnly$
 True��$	��200��$	��200��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$) #Название остановки��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+�� $ 
Horizontal=�$��Center=�$��10 10 10 10q�.+��� -	   $��Добавить��$��75��$��0 0 10 0q�$
 Hand���� -
   $��Удалить��$��75��$
 Hand��