   M S B A M L   `   `   `  ���� R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:IntercityTransportation.Windows.Drivers'IntercityTransportation.Windows.Drivers  >    8IntercityTransportation.Windows.Drivers.EditDriverWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Glocal5clr-namespace:IntercityTransportation.Windows.Drivers       � Title$3  -Редактирование водителя��$	��450��$	��800��.����  �� Orientation$ 
Horizontal=�$��10 10 10 10q�.+��� $
��Auto��.+��� $ 
Horizontal=�.+��� $��Имя��$
��Left=�$��Center=�$	��160����  �� TextWrapping$
 Wrap=�$��Center=�$	��120��$��20������  �� Path$ Driver.FirstName��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Фамилия��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120��$��20������ $ Driver.LastName��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Отчесвто��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120��$��20������ $ Driver.MiddleName��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Дата рождения��$
��Left=�$��Center=�$	��160��(  "System.Windows.Controls.DatePicker     SelectedDateFormat$ Short=�$��Center=�$��Center=�$	��120��   Text �� $ Driver.BirthDate� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Категория��$
��Left=�$��Center=�$	��160���� -    ��Name$ DriverCategoryTextBox��$
 Wrap=�	 �� 
IsReadOnly$
	 True��$��Center=�$	��120��$��20��
 � Cursor$
 Arrow������ $$ Driver.DriverCategory.Category��� -   $'��!Выбрать категорию��$	��120��$��20��$��	10 0 10 0q�$

 Hand���� $ 
Horizontal=�$��0 5 0 0q�.+��� $��
Класс��$��Center=�$	��160���� $	��120��$��20������ *DriverClassColumn+ �� SelectedItem �� *Driver.DriverClass+�� $ 
Horizontal=�$��0 5 0 0q�.+��� $��Опыт работы��$
��Left=�$��Center=�$	��160���� $
 Wrap=�$��Center=�$	��120��$��20������ $ Driver.WorkExperience��� -   $��Сохранить��$��Center=�$	��120��$��20��$��
30 10 10 0q�$

 Hand���� $
��Auto��$��Center=�$��20 0 0 0q�.+��� .��
Фото�� $	��0.3q�
���   �._��� -    ��Name$ DriverPhoto��$	��300��$	��300��$��10q�$	��300��$	��300��$��2������ *BitmapPhoto+�� -   $��Выбрать фото��$	��100��$��20��$��10q�$

 Hand��