   M S B A M L   `   `   `  ���� R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:IntercityTransportation.Windows.Vehicles(IntercityTransportation.Windows.Vehicles  @    :IntercityTransportation.Windows.Vehicles.EditVehicleWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Hlocal6clr-namespace:IntercityTransportation.Windows.Vehicles       � Title$3  -Редактирование автобуса��$	��450��$	��800��.����  �� Orientation$ 
Horizontal=�$��10 10 10 10q�.+��� $
��Auto��.+��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Гос номер��$
��Left=�$��Center=�$	��160����  �� TextWrapping$
 Wrap=�$��Center=�$	��120��$��20������  �� Path$ Vehicle.GovernmentNumber��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��
Марка��$
��Left=�$��Center=�$	��160���� -    ��Name$ BrandTextBox��$
 Wrap=� �� 
IsReadOnly$
 True��$��Center=�$	��120��$��20�� � Cursor$ Arrow������ $ Vehicle.Brand.Name��� -   $��Выбрать марку��$	��120��$��20��$��	10 0 10 0q�$
 Hand���� $ 
Horizontal=�.+��� $��Модель��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120��$��20������ $ Vehicle.Model��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Вместимость��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120��$��20������ $ Vehicle.SeatCount��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Год выпуска��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120��$��20������ $ Vehicle.ReleaseYear��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Год ремонта��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120��$��20������ $ Vehicle.RepairYear��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Пробег��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120��$��20������ $ Vehicle.Mileage��� -   $��Сохранить��$��Center=�$	��120��$��20��$��
30 10 10 0q�$
 Hand���� $
��Auto��$��Center=�$��20 0 0 0q�.+��� .��
Фото�� $	��0.3q�
���   �._��� -    ��Name$ VehiclePhoto��$	��300��$	��300��$��10q�$	��300��$	��300��$��2������ *BitmapPhoto+�� -   $��Выбрать фото��$	��100��$��20��$��10q�$
 Hand��