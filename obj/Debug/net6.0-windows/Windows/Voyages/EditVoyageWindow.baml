   M S B A M L   `   `   `  ����R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:IntercityTransportation.Windows.Voyages'IntercityTransportation.Windows.Voyages  5   	   >    8IntercityTransportation.Windows.Voyages.EditVoyageWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:IntercityTransportation.Windows.Voyages     5   	     � Title$-  'Редактирование рейса��5   	   $	��450��6&   $	��800��63   .��5	      �� $��10q�6    �� Orientation$ Vertical=�6   .+�5
   
   �� .+�5      �� $
��Auto��6   $
��Left=�6&   .+�5      �� $ 
Horizontal=�6   $��5q�66   .+�5      �� $ Vertical=�6!   .+�5      �� $ 
Horizontal=�6%   .+�5      �� $��Дата рейса��6$   $
��Left=�69   $��Center=�6T   $	��160��6o   (  "System.Windows.Controls.DatePicker  5      $��Center=�6)   $��Center=�6F   $	��120��6a      Text 5      ��  �� Path$ Voyage.VoyageDate� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5      �� 5      $ 
Horizontal=�6%   .+�5      �� $��Общая выручка��6$   $
��Left=�6<   $��Center=�6W   $	��160��6r   �� 5       �� TextWrapping$
 Wrap=�6&   $��Center=�6;   $	��120��6V   ��5      �� $ Voyage.TotalRevenues�5      �� 5      $ 
Horizontal=�6%   .+�5      �� $/��)Кол. проданных билетов��6$   $
��Left=�6E   $��Center=�6`   $	��160��6{   �� 5      $
 Wrap=�6&   $��Center=�6;   $	��120��6V   ��5      �� $ Voyage.TicketCount�5      5      5       5!      5"      �� 5$   
   $��10q�6   $
��Auto��6!   $
��Auto��6.   $ Vertical=�6<   .+�5%      �� $
��Auto��6   $��80��6'   .+�5&      �� $��3q�6   $ 
Horizontal=�6(   $��Stretch=�6A   .+�5'      �� $��Водитель��6   $
��Left=�6/   $��Center=�6J   $	��160��6e   �� 5(      -   5        $��Изменить��5(      $
��Auto��6Q   $��20��6^    � Cursor$
 Hand��6j   5)      &   System.Windows.Controls.DataGrid  5*      -   5          Name$ 
DriverGrid��5*      	   
IsReadOnly$
	 True��6/   
   AutoGenerateColumns$
 False��6A      Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6K      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   �� *	FirstName+6X     5-      $ Фамилия��6J   $ * 6[    6-   �� *
LastName+6[     5.      $ Отчество��6L   $ * 6^    6-   �� *
MiddleName+6^     5/      $ Дата рождения��6l   $ * 6�    6-   �� *	BirthDate+ �� StringFormat$ {0:dd/MM/yyyy}��6�     50      $ Категория��6Y   $ * 6l    6-   �� *DriverCategory.Category+6l     51      $ 
Класс��6M   $ * 6\    6-   �� *DriverClass+6\     52      $ Стаж��6P   $ * 6^    6-   �� *WorkExperience+6^   54      55      �� 57      $
��Auto��6   $��80��6'   .+�58      �� $��3q�6   $ 
Horizontal=�6(   $��Stretch=�6A   .+�59      �� $��Автобус��6   $
��Left=�6.   $��Center=�6I   $	��160��6d   �� 5:      -   5        $��Изменить��5:      $
��Auto��6R   $��20��6_   $
 Hand��6k   5;        5<      -   5        $ VehicleGrid��5<      $
	 True��60   $
 False��6B    5=        5>      $ 
Марка��6L   $ * 6[    6-   �� *
Brand.Name+6[     5?      $ Модель��6G   $ * 6W    6-   �� *Model+6W     5@      $ Гос. номер��6R   $ * 6f    6-   �� *GovernmentNumber+6f     5A      $# Количество мест��6K   $ * 6d    6-   �� *	SeatCount+6d     5B      $ Год ремонта��6L   $ * 6a    6-   �� *
RepairYear+6a     5C      $ Год выпуска��6M   $ * 6b    6-   �� *ReleaseYear+6b     5D      $ Пробег��6I   $ * 6Y    6-   �� *	Mileage+6Y   5F      5G      �� 5I      $
��Auto��6   $��80��6'   .+�5J      �� $��3q�6   $ 
Horizontal=�6(   $��Stretch=�6A   .+�5K      �� $��Маршрут��6   $
��Left=�6.   $��Center=�6I   $	��160��6d   �� 5L      -   5        $��Изменить��5L      $
��Auto��6P   $��20��6]   $
 Hand��6i   5M        5N      -   5        $ 	RouteGrid��5N      $
	 True��6.   $
 False��6@    5O        5P      $ Шифр��6D   $ * 6R    6-   �� *Id+6R     5Q      $# Начальный пункт��6T   $ * 6m    6-   �� *StartingPoint.Name+6m     5R      $! Конечный пункт��6R   $ * 6j    6-   �� *EndingPoint.Name+6j     5S      $' !Время отправления��6n   $ * 6�    6-   �� *DepartureTime+$ {0:hh:mm tt}��6�     5T      $ Время в пути��6k   $ * 6�    6-   �� *
TravelTime+$ {0:HH:mm:ss}��6�   5V      5W      5Y      �� 5Z   
   -   5        $��Сохранить��5Z      $��Right=�6%   $	��100��6`   $
 Hand��6l   5[      5\      