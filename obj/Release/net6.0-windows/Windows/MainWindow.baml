   M S B A M L   `   `   `  ���� R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:IntercityTransportationIntercityTransportation  (    "IntercityTransportation.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     7local%clr-namespace:IntercityTransportation       � WindowStartupLocation$  CenterScreen=� � Title$ Главное меню��$	��490��$	��360��$	��451��$	��800��.���� $
��Auto��.+�o� -   $
��Menu��$��25��$	��Top=�$��	10 0 10 0q����� .R�]� $��Stretch=�.@�m� $��Таблицы�� � Cursor$
 Hand��.@�m� -   $��BrandMenuItem��$#��Марки автобусов��$
 Hand��m� -   $��DriverCategoryMenuItem��$+��%Категории водителей��$
 Hand��m� -   $��CityMenuItem��$��Города��$
 Hand��m� -   $��BusStopMenuItem��$��Остановки��$
 Hand��m� -   $��DriverMenuItem��$��Водители��$
 Hand��m� -   $��VehicleMenuItem��$��Автобусы��$
 Hand��m� -   $��RouteMenuItem��$��Маршруты��$
 Hand��m� -	   $��VoyageMenuItem��$��
Рейсы��$
 Hand��m� -
   $��Справка��$
 Hand��m� $��Настройки��$
 Hand��.@�m� -   $��Смена пароля��$
 Hand��m� -   $��AdminMenuItem��$/��)Панель администратора��$
 Hand��m� -   $��
Выход��$
 Hand��$��Right=��� -   $��TitleTextBox��$�� ��$��Center=�$��0q�$��	ExtraBold"�$��
10 10 10 0q��� -   $��
TabControl��$	��400��$��0q�.@��� -    ��Name$ BrandTabItem��$#��Марки автобусов��$y�Hidden=�$��0��.��� -    �Name$ BrandGridItem��$��10q�$	��370�� � RowDefinitions �� $��0.90* ��� $��0.10* � � ColumnDefinitions �� $��* �.+�&   System.Windows.Controls.DataGrid  -     Name$ 	BrandGrid��   
IsReadOnly$
 True��	   AutoGenerateColumns$	 False��$
��Auto��
   Columns
 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$! Название марки��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+�� $��1�� �� Orientation$ 
Horizontal=�$��0 10 0 0q�.+��� -    ��Name$ AddBrandButton��$��Добавить��$
 Hand��$	��100��$��25���� -   $ EditBrandButton��$ ��Редактировать��$
 Hand��$	��100��$��25��$��	10 0 10 0q��� -   $ DeleteBrandButton��$��Удалить��$
 Hand��$	��100��$��25���� -   $ DriverCategoryTabItem��$+��%Категории водителей��$y�Hidden=�$��0��.��� -   $ DriverCategoryGridItem��$��10q�$	��370�� �� $��0.90* ��� $��0.10* � �� $��* �.+�  -   $ DriverCategoryGrid��$
 True��$	 False��
   $) #Название категории��$ *  �� *
Category+�� $��1��$ 
Horizontal=�$��0 10 0 0q�.+��� -   $ AddDriverCategoryButton��$��Добавить��$
 Hand��$	��100��$��25���� -   $ EditDriverCategoryButton��$ ��Редактировать��$
 Hand��$	��100��$��25��$��	10 0 10 0q��� -   $  DeleteDriverCategoryButton��$��Удалить��$
 Hand��$	��100��$��25���� -   $ CityTabItem��$��Города��$y�Hidden=�$��0��.��� -   $ CityGridItem��$��10q�$	��370�� �� $��0.90* ��� $��0.10* � �� $��* �.+�  -   $ CityGrid��$
 True��$	 False��
   $# Название города��$ *  �� *Name+�� $��1��$ 
Horizontal=�$��0 10 0 0q�.+��� -   $ AddCityButton��$��Добавить��$
 Hand��$	��100��$��25���� -    $ EditCityButton��$ ��Редактировать��$
 Hand��$	��100��$��25��$��	10 0 10 0q��� -!   $ DeleteCityButton��$��Удалить��$
 Hand��$	��100��$��25���� -"   $ BusStopTabItem��$��Города��$y�Hidden=�$��0��.��� -#   $ BusStopGridItem��$��10q�$	��370�� �� $��0.90* ��� $��0.10* � �� $��* �.+�  -$   $ BusStopGrid��$
 True��$	 False��
   $) #Название остановки��$ *  �� *Name+�� $��1��$ 
Horizontal=�$��0 10 0 0q�.+��� -%   $ AddBusStopButton��$��Добавить��$
 Hand��$	��100��$��25���� -&   $ EditBusStopButton��$ ��Редактировать��$
 Hand��$	��100��$��25��$��	10 0 10 0q��� -'   $ DeleteBusStopButton��$��Удалить��$
 Hand��$	��100��$��25���� -(   $ DriverTabItem��$��Водители��$y�Hidden=�$��0��.��� -)   $ DriverGridItem��$��10q�$	��370�� �� $��0.90* ��� $��0.10* � �� $��* �.+�  -*   $ 
DriverGrid��$
 True��$	 False��
   $ Имя��$ *  �� *	FirstName+  $ Фамилия��$ *  �� *
LastName+  $ Отчество��$ *  �� *
MiddleName+  $ Дата рождения��$ *  �� *	BirthDate+ �� StringFormat$ {0:dd/MM/yyyy}��  $ Категория��$ *  �� *DriverCategory.Category+  $ 
Класс��$ *  �� *DriverClass+  $ Стаж��$ *  �� *WorkExperience+�� $��1��$ 
Horizontal=�$��0 10 0 0q�.+��� -+   $ AddDriverButton��$��Добавить��$
 Hand��$	��100��$��25���� -,   $ EditDriverButton��$ ��Редактировать��$
 Hand��$	��100��$��25��$��	10 0 10 0q��� --   $ DeleteDriverButton��$��Удалить��$
 Hand��$	��100��$��25���� -.   $ VehicleTabItem��$��Автобусы��$y�Hidden=�$��0��.��� -/   $ VehicleGridItem��$��10q�$	��370�� �� $��0.90* ��� $��0.10* � �� $��* �.+�  -0   $ VehicleGrid��$
 True��$	 False��
   $ 
Марка��$ *  �� *
Brand.Name+  $ Модель��$ *  �� *Model+  $ Гос. номер��$ *  �� *GovernmentNumber+  $# Количество мест��$ *  �� *	SeatCount+  $ Год ремонта��$ *  �� *
RepairYear+  $ Год выпуска��$ *  �� *ReleaseYear+  $ Пробег��$ *  �� *	Mileage+�� $��1��$ 
Horizontal=�$��0 10 0 0q�.+��� -1   $ AddVehicleButton��$��Добавить��$
 Hand��$	��100��$��25���� -2   $ EditVehicleButton��$ ��Редактировать��$
 Hand��$	��100��$��25��$��	10 0 10 0q��� -3   $ DeleteVehicleButton��$��Удалить��$
 Hand��$	��100��$��25���� -4   $ RouteTabItem��$��Автобусы��$y�Hidden=�$��0��.��� -5   $ RouteGridItem��$��10q�$	��370�� �� $��0.90* ��� $��0.10* � �� $��* �.+�  -6   $ 	RouteGrid��$
 True��$	 False��
   $ Шифр��$ *  �� *Id+  $# Начальный пункт��$ *  �� *StartingPoint.Name+  $! Конечный пункт��$ *  �� *EndingPoint.Name+  $' !Время отправления��$ *  �� *DepartureTime+$ {0:hh:mm tt}��  $ Время в пути��$ *  �� *
TravelTime+$ {0:HH:mm:ss}���� $��1��$ 
Horizontal=�$��0 10 0 0q�.+��� -7   $ AddRouteButton��$��Добавить��$
 Hand��$	��100��$��25���� -8   $ EditRouteButton��$ ��Редактировать��$
 Hand��$	��100��$��25��$��	10 0 10 0q��� -9   $ DeleteRouteButton��$��Удалить��$
 Hand��$	��100��$��25���� -:   $ VoyageTabItem��$��
Рейсы��$y�Hidden=�$��0��.��� -;   $ VoyageGridItem��$��10q�$	��370�� �� $��0.90* ��� $��0.10* � �� $��* �.+�  -<   $ 
VoyageGrid��$
 True��$	 False��
   $% Фамилия водителя��$ *  �� *Driver.LastName+  $! Марка автобуса��$ *  �� *Vehicle.Brand.Name+  $ Общая выручка��$ *  �� *TotalRevenues+  $ Шифр маршрута��$ *  �� *
Route.Id+  $# Начальный пункт��$ *  �� *Route.StartingPoint.Name+  $! Конечный пункт��$ *  �� *Route.EndingPoint.Name+  $ Дата рейса��$ *  �� *
VoyageDate+$ {0:dd/MM/yyyy}���� $��1��$ 
Horizontal=�$��0 10 0 0q�.+��� -=   $ AddVoyageButton��$��Добавить��$
 Hand��$	��100��$��25���� ->   $ EditVoyageButton��$ ��Редактировать��$
 Hand��$	��100��$��25��$��	10 0 10 0q��� -?   $ DeleteVoyageButton��$��Удалить��$
 Hand��$	��100��$��25���� $��
Поиск��$��Center=�$��50���� -@    ��Name$ SearchVoyageTextBox��$
��Left=� �� TextWrapping$
 Wrap=�$��Center=�$	��120���� -A   $��Искать��$	��100��$
 Hand��$��25��$��	10 0 10 0q��� -B   $��Экспорт��$	��100��$
 Hand��$��25���� -C   $ AdminTabItem��$/��)Панель администратора��$y�Hidden=�$��0��.��� -D   $ AdminGridItem��$��10q�$	��370�� �� $��0.90* ��� $��0.10* � .+�  -E   $ UserGrid��   CanUserAddRows$ False��$	 False��
      
IsReadOnly$
 True��$ Индефиктор��$ *  �� *Id+  $ 
Емаил��$ *  �� *Email+  $
 True��$ Хэш пароля��$ *  �� *
Password+4  .System.Windows.Controls.DataGridComboBoxColumn  -F   UserTypeColumn��$ Тип доступа��$ *    SelectedItemBinding �� *
UserType+�� $��1��$ 
Horizontal=�$��0 10 0 0q�.+��� -G   $ SaveUserButton��$��Сохранить��$	��100��$��25��$
 Hand���� -H   $ EditAccessRightButton��$ ��Редактировать��$	��100��$��25��$��	10 0 10 0q�$
 Hand���� -I   $ DeleteUserButton��$��Удалить��$	��100��$��25��$
 Hand���� -J   $ HelpTabItem��$��Справка��$y�Hidden=�$��0��.��� $��10q�.+�� $	��400��.+��� .+��� $1��+Как работает программа:��$
��Auto��$��Center=�$��	ExtraBold"��� $
��Wrap=���Пользователь, при разрешённых правах доступа администратором, может читать, добавлять, редактировать, удалять необходимые данные;�� �� ��Пользователь имеет возможность поиска по таблице рейсов, а также может экспортироовать её в эксель и ворд файл;�� �� nlУ всех пользователя есть возможность для изменения пароля;�� �� ...�� -K   $ RecoverPasswordTabItem��$��Смена пароля��$y�Hidden=�$��0��.��� -L   $ RecoverPasswordGridItem��$��10q�.+��� $��0,5,0,0q�$ Vertical=�.+��� $��Center=�.+��� ��Для изменения текущего пароля введите старый пароль, новый пароль и повторите новый пароль.�� $��0,10,0,0q�$��Center=�.+��� $ 
Horizontal=�$��0,10,0,0q�.+��� $��Старый пароль��$��Center=�$	��160��G� -M    G�Name$ OldPasswordTexBox��$
��Left=�$��Center=�$	��140���� $ 
Horizontal=�$��0,10,0,0q�.+��� $��Новый паролль��$��Center=�$	��160��G� -N   $ NewPasswordTexBox��$
��Left=�$��Center=�$	��140���� $ 
Horizontal=�$��0,10,0,0q�.+��� $,��&Повтор нового пароля��$��Center=�$	��160��G� -O   $ ConfirmPasswordTexBox��$
��Left=�$��Center=�$	��140���� $��Center=�$ 
Horizontal=�$��0,25,0,0q�$
��Auto��$��50��$	��Top=�.+��� -P   $ RecoverPasswordButton��$��Изменить��$	��100��$��25��