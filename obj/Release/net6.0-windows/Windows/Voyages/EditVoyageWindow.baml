   M S B A M L   `   `   `  ���� R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:IntercityTransportation.Windows.Voyages'IntercityTransportation.Windows.Voyages  >    8IntercityTransportation.Windows.Voyages.EditVoyageWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Glocal5clr-namespace:IntercityTransportation.Windows.Voyages       � Title$-  'Редактирование рейса��$	��450��$	��800��.���� $��10q� �� Orientation$ Vertical=�.+��� .+��� $
��Auto��$
��Left=�.+��� $ 
Horizontal=�$��5q�.+��� $ Vertical=�.+��� $ 
Horizontal=�.+��� $��Дата рейса��$
��Left=�$��Center=�$	��160��(  "System.Windows.Controls.DatePicker  $��Center=�$��Center=�$	��120��   Text ��  �� Path$ Voyage.VoyageDate� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $ 
Horizontal=�.+��� $��Общая выручка��$
��Left=�$��Center=�$	��160����  �� TextWrapping$
 Wrap=�$��Center=�$	��120������ $ Voyage.TotalRevenues��� $ 
Horizontal=�.+��� $/��)Кол. проданных билетов��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120������ $ Voyage.TicketCount��� $��10q�$
��Auto��$
��Auto��$ Vertical=�.+��� $
��Auto��$��80��.+��� $��3q�$ 
Horizontal=�$��Stretch=�.+��� $��Водитель��$
��Left=�$��Center=�$	��160���� -   $��Изменить��$
��Auto��$��20�� � Cursor$
 Hand��&   System.Windows.Controls.DataGrid  -     Name$ 
DriverGrid��	   
IsReadOnly$
	 True��
   AutoGenerateColumns$
 False��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	FirstName+  $ Фамилия��$ *  �� *
LastName+  $ Отчество��$ *  �� *
MiddleName+  $ Дата рождения��$ *  �� *	BirthDate+ �� StringFormat$ {0:dd/MM/yyyy}��  $ Категория��$ *  �� *DriverCategory.Category+  $ 
Класс��$ *  �� *DriverClass+  $ Стаж��$ *  �� *WorkExperience+�� $
��Auto��$��80��.+��� $��3q�$ 
Horizontal=�$��Stretch=�.+��� $��Автобус��$
��Left=�$��Center=�$	��160���� -   $��Изменить��$
��Auto��$��20��$
 Hand��  -   $ VehicleGrid��$
	 True��$
 False��   $ 
Марка��$ *  �� *
Brand.Name+  $ Модель��$ *  �� *Model+  $ Гос. номер��$ *  �� *GovernmentNumber+  $# Количество мест��$ *  �� *	SeatCount+  $ Год ремонта��$ *  �� *
RepairYear+  $ Год выпуска��$ *  �� *ReleaseYear+  $ Пробег��$ *  �� *	Mileage+�� $
��Auto��$��80��.+��� $��3q�$ 
Horizontal=�$��Stretch=�.+��� $��Маршрут��$
��Left=�$��Center=�$	��160���� -   $��Изменить��$
��Auto��$��20��$
 Hand��  -   $ 	RouteGrid��$
	 True��$
 False��   $ Шифр��$ *  �� *Id+  $# Начальный пункт��$ *  �� *StartingPoint.Name+  $! Конечный пункт��$ *  �� *EndingPoint.Name+  $' !Время отправления��$ *  �� *DepartureTime+$ {0:hh:mm tt}��  $ Время в пути��$ *  �� *
TravelTime+$ {0:HH:mm:ss}���� -   $��Сохранить��$��Right=�$	��100��$
 Hand��