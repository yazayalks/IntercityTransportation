   M S B A M L   `   `   `  ����R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullc6clr-namespace:IntercityTransportation.Windows.Vehicles(IntercityTransportation.Windows.Vehicles  5   	   @    :IntercityTransportation.Windows.Vehicles.EditVehicleWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Hlocal6clr-namespace:IntercityTransportation.Windows.Vehicles     5   	     � Title$3  -Редактирование автобуса��5   	   $	��450��6)   $	��800��66   .��5	      ��  �� Orientation$ 
Horizontal=�6   $��10 10 10 10q�6*   .+�5
   
   �� $
��Auto��6   .+�5      �� $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5      �� $��Гос номер��6   $
��Left=�6,   $��Center=�6G   $	��160��6b   �� 5       �� TextWrapping$
 Wrap=�6   $��Center=�6.   $	��120��6I   $��20��6U   ��5      ��  �� Path$ Vehicle.GovernmentNumber�5      �� 5      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5      �� $��
Марка��6   $
��Left=�6(   $��Center=�6C   $	��160��6^   �� 5      -   5         ��Name$ BrandTextBox��5      $
 Wrap=�60    �� 
IsReadOnly$
 True��6D   $��Center=�6W   $	��120��6r   $��20��6~    � Cursor$ Arrow��6�   ��5      �� $ Vehicle.Brand.Name��� 5      -   5        $��Выбрать марку��5      $	��120��6Q   $��20��6]   $��	10 0 10 0q�6i   $
 Hand��6|   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Модель��6   $
��Left=�6)   $��Center=�6D   $	��160��6_   �� 5      $
 Wrap=�6   $��Center=�6.   $	��120��6I   $��20��6U   ��5      �� $ Vehicle.Model�5      �� 5      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5       �� $��Вместимость��6   $
��Left=�6.   $��Center=�6I   $	��160��6d   �� 5!      $
 Wrap=�6   $��Center=�6.   $	��120��6I   $��20��6U   ��5"      �� $ Vehicle.SeatCount�5#      �� 5$      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5%      �� $��Год выпуска��6   $
��Left=�6.   $��Center=�6I   $	��160��6d   �� 5&      $
 Wrap=�6   $��Center=�6.   $	��120��6I   $��20��6U   ��5'      �� $ Vehicle.ReleaseYear�5(      �� 5)      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5*      �� $��Год ремонта��6   $
��Left=�6.   $��Center=�6I   $	��160��6d   �� 5+      $
 Wrap=�6   $��Center=�6.   $	��120��6I   $��20��6U   ��5,      �� $ Vehicle.RepairYear�5-      �� 5/      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�50      �� $��Пробег��6   $
��Left=�6)   $��Center=�6D   $	��160��6_   �� 51      $
 Wrap=�6   $��Center=�6.   $	��120��6I   $��20��6U   ��52      �� $ Vehicle.Mileage�53      �� 55      -   5        $��Сохранить��55      $��Center=�6)   $	��120��6e   $��20��6q   $��
30 10 10 0q�6}   $
 Hand��6�   56      �� 57   
   $
��Auto��6   $��Center=�6"   $��20 0 0 0q�6?   .+�58      �� .��6   
Фото5:      �� 5;      $	��0.3q�6   
���   �._�5<      �� -   5         ��Name$ VehiclePhoto��5<      $	��300��6M   $	��300��6Y   $��10q�6f   $	��300��6r   $	��300��6�   $��2��6�   ��6.   �� *BitmapPhoto+6�   5=      �� 5>      -   5        $��Выбрать фото��5>      $	��100��6P   $��20��6]   $��10q�6i   $
 Hand��6u   5?      5@      5A      