   M S B A M L   `   `   `  ����R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:IntercityTransportation.Windows.Routes&IntercityTransportation.Windows.Routes  5   	   <    6IntercityTransportation.Windows.Routes.EditRouteWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:IntercityTransportation.Windows.Routes     5   	   ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6L     � Title$3  -Редактирование маршрута��5   	   $	��450��6)   $	��800��66   .��5	      ��  �� Orientation$ 
Horizontal=�6   $��10 10 10 10q�6*   .+�5
   
   �� $
��Auto��6   .+�5      �� $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5      �� $#��Начальный пункт��6   $
��Left=�62   $��Center=�6M   $	��160��6h   �� 5      -   5         ��Name$ StartingPointTextBox��5       �� TextWrapping$
 Wrap=�68    �� 
IsReadOnly$
 True��6L   $��Center=�6_   $	��120��6z   $��20��6�    � Cursor$ Arrow��6�   ��5      ��  �� Path$ Route.StartingPoint.Name��� 5      -   5        $2��,Выбрать начальный пункт��5      $	��160��6c   $��20��6o   $��	10 0 10 0q�6{   $
 Hand��6�   5      �� 5      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5      �� $!��Конечный пункт��6   $
��Left=�61   $��Center=�6L   $	��160��6g   �� 5      -   5        $ EndingPointTextBox��5      $
 Wrap=�66   $
 True��6J   $��Center=�6]   $	��120��6x   $��20��6�   $ Arrow��6�   ��5      �� $ Route.EndingPoint.Name��� 5      -   5        $0��*Выбрать конечный пункт��5      $	��160��6`   $��20��6l   $��	10 0 10 0q�6x   $
 Hand��6�   5      �� 5      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5      �� $'��!Время отправления��6   $
��Left=�64   $��Center=�6O   $	��160��6j   "  Xceed.Wpf.Toolkit.TimePicker  5      -   5        $��DepartureTimePicker��5   "   $	��120��6=   ,  &Xceed.Wpf.Toolkit.Primitives.InputBase   Text 6I   �� $ Route.DepartureTime��� 5      $$��Часы : минуты: AM/PM��6   $��Center=�67   $��Center=�6T   $	��160��6o   $��	10 0 10 0q�6|   5      �� 5       $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5!      �� $��Время в пути��6   $
��Left=�6/   $��Center=�6J   $	��160��6e     5"      -   5        $��TravelTimePicker��5"   "   $	��120��6:   &   Xceed.Wpf.Toolkit.DateTimeUpDown   Format$ Custom=�6F   	   FormatString$	 d:HH:mm��6V    6p   �� $ Route.TravelTime��� 5#      $&�� Дни : часы : минуты��6   $��Center=�66   $��Center=�6S   $	��160��6n   $��	10 0 10 0q�6{   5$      �� 5&      -   5        $��Сохранить��5&      $��Center=�6)   $	��120��6d   $��20��6p   $��-10 10 10 0q�6|   $
 Hand��6�   5'      �� 5(   
   $
��Auto��6   $��Center=�6"   $��20 0 0 0q�6?   .+�5)      �� .��6   Остановки5+      &   System.Windows.Controls.DataGrid  5,      -   5        
  Name$
 BusStopGrid��5,         AutoGenerateColumns$ False��6,      
IsReadOnly$
 True��6H   $	��200��6Z   $	��200��6f      Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$) #Название остановки��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5/   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5.   )   �� *Name+5/   )   52      �� 53      $ 
Horizontal=�6   $��Center=�62   $��10 10 10 10q�6O   .+�54      �� -	   5        $��Добавить��54      $��75��6K   $��0 0 10 0q�6V   $
 Hand��6h   �� 55      -
   5        $��Удалить��55      $��75��6M   $
 Hand��6X   56      57      58      59      