   M S B A M L   `   `   `  ����R  NIntercityTransportation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:IntercityTransportation.Windows.Drivers'IntercityTransportation.Windows.Drivers  5   	   >    8IntercityTransportation.Windows.Drivers.EditDriverWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:IntercityTransportation.Windows.Drivers     5   	     � Title$3  -Редактирование водителя��5   	   $	��450��6)   $	��800��66   .��5	      ��  �� Orientation$ 
Horizontal=�6   $��10 10 10 10q�6*   .+�5
   
   �� $
��Auto��6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��Имя��6   $
��Left=�6&   $��Center=�6A   $	��160��6\   �� 5       �� TextWrapping$
 Wrap=�6   $��Center=�6.   $	��120��6I   $��20��6U   ��5      ��  �� Path$ Driver.FirstName�5      �� 5      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5      �� $��Фамилия��6   $
��Left=�6*   $��Center=�6E   $	��160��6`   �� 5      $
 Wrap=�6   $��Center=�6.   $	��120��6I   $��20��6U   ��5      �� $ Driver.LastName�5      �� 5      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5      �� $��Отчесвто��6   $
��Left=�6+   $��Center=�6F   $	��160��6a   �� 5      $
 Wrap=�6   $��Center=�6.   $	��120��6I   $��20��6U   ��5      �� $ Driver.MiddleName�5      �� 5      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5      �� $��Дата рождения��6   $
��Left=�60   $��Center=�6K   $	��160��6f   (  "System.Windows.Controls.DatePicker  5         SelectedDateFormat$ Short=�6   $��Center=�68   $��Center=�6U   $	��120��6p      Text 5       �� $ Driver.BirthDate� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5!      �� 5#      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5$      �� $��Категория��6   $
��Left=�6,   $��Center=�6G   $	��160��6b   �� 5%      -   5         ��Name$ DriverCategoryTextBox��5%      $
 Wrap=�69   	 �� 
IsReadOnly$
	 True��6M   $��Center=�6`   $	��120��6{   $��20��6�   
 � Cursor$
 Arrow��6�   ��5&      �� $$ Driver.DriverCategory.Category��� 5'      -   5        $'��!Выбрать категорию��5'      $	��120��6^   $��20��6j   $��	10 0 10 0q�6v   $

 Hand��6�   5(      �� 5*      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�5+      �� $��
Класс��6   $��Center=�6)   $	��160��6D   �� 5,      $	��120��6   $��20��6(   ��64   �� *DriverClassColumn+ �� SelectedItem 5-      �� *Driver.DriverClass+5.      �� 50      $ 
Horizontal=�6   $��0 5 0 0q�62   .+�51      �� $��Опыт работы��6   $
��Left=�6.   $��Center=�6I   $	��160��6d   �� 52      $
 Wrap=�6   $��Center=�6.   $	��120��6I   $��20��6U   ��53      �� $ Driver.WorkExperience�54      �� 56      -   5        $��Сохранить��56      $��Center=�6)   $	��120��6e   $��20��6q   $��
30 10 10 0q�6}   $

 Hand��6�   57      �� 58   
   $
��Auto��6   $��Center=�6"   $��20 0 0 0q�6?   .+�59      �� .��6   
Фото5;      �� 5<      $	��0.3q�6   
���   �._�5=      �� -   5         ��Name$ DriverPhoto��5=      $	��300��6L   $	��300��6X   $��10q�6e   $	��300��6q   $	��300��6�   $��2��6�   ��6-   �� *BitmapPhoto+6�   5>      �� 5?      -   5        $��Выбрать фото��5?      $	��100��6O   $��20��6\   $��10q�6h   $

 Hand��6u   5@      5A      5B      