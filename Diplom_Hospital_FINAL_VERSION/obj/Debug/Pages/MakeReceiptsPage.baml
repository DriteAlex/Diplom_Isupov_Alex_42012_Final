   M S B A M L   `   `   `  ����J  FDiplom_Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Diplom_Hospital.PagesDiplom_Hospital.Pages  5      ,    &Diplom_Hospital.Pages.MakeReceiptsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Diplom_Hospital.Pages     5        N� Title$  MakeReceiptsPage��5       � 	Resources 5	         ButtonStyle �� 
TargetType �� Property �� Value��%a  &	        �� 5
   
   " ��6$   .�5      ��  � ��$ Bottom=�62   �� 5       � ��$ 16(�6)   �� 5       � ��$ Arial Narrow)�6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 25��6'   �� 5       � ��$ 20q�6'   �� 5       � ��
 ��� �6+   �� 5       � ��
 �����6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgBalanceMedicine��5         CanUserAddRows .  	   AutoGenerateColumns	 .  $��1��6a   $��1��6n   $	��Top=�6~   
   Columns
 5      4  .System.Windows.Controls.DataGridTemplateColumn  5       -   5        	IdOrd��,  &System.Windows.Controls.DataGridColumn   Header$ OrderId��5    8      Width5  /System.Windows.Controls.DataGridLengthConverter$ 55 6I      CellTemplate 5!      �� 5"      .R�5#      �� ��6&   �� *	IdOrder+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5$      5&        5'      $% Дата поступления��6)   $	 115 6C    5(      �� 5)      .R�5*      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *LogOfReceipts.DateRecepts+$ TwoWay=�$ PropertyChanged=�5+      5-      0  *System.Windows.Controls.DataGridTextColumn  5.      -   5        	IdMed��$	 №��5.   4   $ 35 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Medicine.Id+6_     5/      $ Название��6%   $	 125 6a    67   �� *Medicine.MedicineName+   ElementStyle 50      �� 51      " ��6    .�52      ��  � ��$
 Wrap=�6=   53      55        56      $ Категория��6%   $	 200 6k    68   �� * Medicine.Category.NameCategory+ 57      �� 58      " ��6    .�59      ��  � ��$
 Wrap=�6=   5:      5<        5=      $0 *Описание/форма выпуска��6%   $	 200 6n    6E   �� *Medicine.Description+ 5>      �� 5?      " ��6    .�5@      ��  � ��$
 Wrap=�6=   5A      5C        5D      -   5        Quan��$ Количество��5D   8   $	 115 6L    5E      �� 5F      .R�5G      �� ��6&   �� *
Quantity+$ TwoWay=�$ PropertyChanged=�5H      5J        5K      -   5        ImplementationMonth��$ 
Месяц��5K   G   $	 115 6V    5L      �� 5M      .R�5N      �� ��6&   �� *#!LogOfReceipts.ImplementationMonth+$ TwoWay=�$ PropertyChanged=�5O      5Q        5R      -   5        ImplementationYear��$ Год��5R   F   $	 115 6S    5S      �� 5T      .R�5U      �� ��6&   �� *" LogOfReceipts.ImplementationYear+$ TwoWay=�$ PropertyChanged=�5V      5X        5Y      -   5        IdHospitalDepartament��$# Номер отделения��5Y   I   $	 115 6b    5Z      �� 5[      .R�5\      �� ��6&   �� *Orders.IdDepartament+$ TwoWay=�$ PropertyChanged=�5]      5_      5a      �� 5b   
   $��
Поиск��6   $��Center=�6    $��	20,15,0,0q�6=   $	��Top=�6P   $	��132��6h   $��Arial Narrow)�6t   $��22(�6�   �� 5c   
   -   5         ��Name$ tbSearh��5c      $��Center=�6#   $��0,60,0,0q�6A   $	��Top=�6S   $	��220��6k   $��30��6w    �� TextWrapping$
 Wrap=�6�   6�   �� 5d   
   $Y��SЛекарства, ожидающие поступления в отделение��6   $��Center=�6G   $��	20,40,0,0q�6d   $	��Top=�6w   $	��534��6�   $��Arial Narrow)�6�   $��22(�6�   $��1��6�   �� 5e   
   $1��+Фильтр по номеру заказа��6   $
��Wrap=�63   $��Center=�6G   $��0,13,0,0q�6d   $	��Top=�6v   $	��122��6�   $��Arial Narrow)�6�   $��22(�6�   $��1��6�   $��56��6�   �� 5f   
   -	   5         ��Name$ cbOrderSelected��5f       �� DisplayMemberPath$ id��6L   $��Center=�6d   $��0,74,0,0q�6�   $��1��6�   $��0��6�   $	��Top=�6�   $	��190��6�    �� SelectedItem 6,   �� *Orders+6�   �� 5g   
   -
   5         ��Name$ 	btnSelect��5g      $��Выбрать��6$   #��[  66   $
��Left=�6[   $��
10,0,0,353q�6�   $��1��6�   $��0��6�   �� 5h   
   -   5        $ btnClear��5h      $��Очистить��6#   #��[  66   $
��Left=�6[   $��125,0,0,353q�6�   $��1��6�   $��0��6�   �� 5i   
   -   5        $ btnAddMedicine��5i      $&�� Добавить на склад��6)   #��[  6E   $
��Left=�6j   $��
30,0,0,293q�6�   $��1��6�   $��0��6�   $	��171��6�   5j      5k      