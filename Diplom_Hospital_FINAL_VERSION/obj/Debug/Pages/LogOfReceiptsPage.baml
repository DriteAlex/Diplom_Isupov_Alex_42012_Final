   M S B A M L   `   `   `  ����J  FDiplom_Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Diplom_Hospital.PagesDiplom_Hospital.Pages  5      -    'Diplom_Hospital.Pages.LogOfReceiptsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Diplom_Hospital.Pages     5        N� Title$  LogOfReceiptsPage��5       � 	Resources 5	         ButtonStyle �� 
TargetType �� Property �� Value��%a  &	        �� 5
   
   " ��6$   .�5      ��  � ��$ Bottom=�62   �� 5       � ��$ 16(�6)   �� 5       � ��$ Arial Narrow)�6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 25��6'   �� 5       � ��$ 20q�6'   �� 5       � ��
 ��� �6+   �� 5       � ��
 �����6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgBalanceMedicine��5         CanUserAddRows .  	   AutoGenerateColumns	 .  $��1��6a   $��1��6n   $	��Top=�6~   
   Columns
 5      4  .System.Windows.Controls.DataGridTemplateColumn  5       -   5        Id��,  &System.Windows.Controls.DataGridColumn   Header$	 №��5    5      Width5  /System.Windows.Controls.DataGridLengthConverter$ 35 6@      CellTemplate 5!      �� 5"      .R�5#      �� ��6&   �� *
IdMedicine+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5$      5&        5'      $% Дата поступления��6)   $	 115 6C    5(      �� 5)      .R�5*      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *DateRecepts+$ TwoWay=�$ PropertyChanged=�5+      5-      0  *System.Windows.Controls.DataGridTextColumn  5.      $ Название��6%   $	 125 6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Medicine.MedicineName+   ElementStyle 5/      �� 50      " ��6    .�51      ��  � ��$
 Wrap=�6=   52      54        55      $ Категория��6%   $	 200 6k    68   �� * Medicine.Category.NameCategory+ 56      �� 57      " ��6    .�58      ��  � ��$
 Wrap=�6=   59      5;        5<      $0 *Описание/форма выпуска��6%   $	 200 6n    6E   �� *Medicine.Description+ 5=      �� 5>      " ��6    .�5?      ��  � ��$
 Wrap=�6=   5@      5B        5C      -   5        Quan��$ Количество��5C   8   $	 115 6L    5D      �� 5E      .R�5F      �� ��6&   �� *QuantityReceipts+$ TwoWay=�$ PropertyChanged=�5G      5I        5J      -   5        ImplementationMonth��$ 
Месяц��5J   G   $	 115 6V    5K      �� 5L      .R�5M      �� ��6&   �� *ImplementationMonth+$ TwoWay=�$ PropertyChanged=�5N      5P        5Q      -   5        ImplementationYear��$ Год��5Q   F   $	 115 6S    5R      �� 5S      .R�5T      �� ��6&   �� *ImplementationYear+$ TwoWay=�$ PropertyChanged=�5U      5W        5X      -   5        IdHospitalDepartament��$# Номер отделения��5X   I   $	 115 6b    5Y      �� 5Z      .R�5[      �� ��6&   �� *IdHospitalDepartament+$ TwoWay=�$ PropertyChanged=�5\      5^      5`      �� 5a   
   $��
Поиск��6   $��Center=�6    $��	20,15,0,0q�6=   $	��Top=�6P   $	��132��6h   $��Arial Narrow)�6t   $��22(�6�   �� 5b   
   -   5         ��Name$ tbSearh��5b      $��Center=�6#   $��0,60,0,0q�6A   $	��Top=�6S   $	��220��6k   $��30��6w    �� TextWrapping$
 Wrap=�6�   6�   �� 5c   
   $Q��KЖурнал лекарств, поступивших в отделение��6   $��Center=�6C   $��	20,40,0,0q�6`   $	��Top=�6s   $	��534��6�   $��Arial Narrow)�6�   $��22(�6�   $��1��6�   �� 5d   
   $=��7Фильтр по категории препарата��6   $
��Wrap=�69   $��Center=�6M   $��0,13,0,0q�6j   $	��Top=�6|   $	��190��6�   $��Arial Narrow)�6�   $��22(�6�   $��1��6�   $��56��6�   �� 5e   
   -   5         ��Name$ 
cbCategory��5e       �� DisplayMemberPath$ NameCategory��6I   $��Center=�6k   $��0,74,0,0q�6�   $��1��6�   $��0��6�   $	��Top=�6�   $	��190��6�    �� SelectedItem 6'   �� *
Category+6�   �� 5f   
   -	   5         ��Name$ 	btnSelect��5f      $��Выбрать��6$   #��[  66   $
��Left=�6[   $��
10,0,0,353q�6�   $��1��6�   $��0��6�   �� 5g   
   -
   5        $ btnClear��5g      $��Очистить��6#   #��[  66   $
��Left=�6[   $��125,0,0,353q�6�   $��1��6�   $��0��6�   �� 5h   
   -   5        $	 btn��5h      $)��#Сформировать отчет��6   #��[  6;   $
��Left=�6`   $��
30,0,0,225q�6{   $��1��6�   $��0��6�   $	��171��6�   6�   5i      5j      