   M S B A M L   `   `   `  ����J  FDiplom_Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Diplom_Hospital.PagesDiplom_Hospital.Pages  5      +    %Diplom_Hospital.Pages.LogWriteOffPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Diplom_Hospital.Pages     5        N� Title$  LogWriteOffPage��5       � 	Resources 5	         ButtonStyle �� 
TargetType �� Property �� Value��%a  &	        �� 5
   
   " ��6$   .�5      ��  � ��$ Bottom=�62   �� 5       � ��$ 16(�6)   �� 5       � ��$ Arial Narrow)�6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 25��6'   �� 5       � ��$ 20q�6'   �� 5       � ��
 ��� �6+   �� 5       � ��
 �����6+   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��250 �6   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgWriteOffMedicine��5         CanUserAddRows .  	   AutoGenerateColumns	 .  $��1��6b   $��1��6o   $	��Top=�6   
   Columns
 5      4  .System.Windows.Controls.DataGridTemplateColumn  5       -   5        	IdBalance��,  &System.Windows.Controls.DataGridColumn   Header$ Складской №��5    <      Width5  /System.Windows.Controls.DataGridLengthConverter$ 85 6Q      CellTemplate 5!      �� 5"      .R�5#      �� ��6&   �� *Id+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5$      5&        5'      -   5        
IdMedicine��$	 №��5'   =   $ 35 6H    5(      �� 5)      .R�5*      �� ��6&   �� *Balance.IdMedicine+$ TwoWay=�$ PropertyChanged=�5+      5-        5.      $ Дата списания��6)   $	 115 6@    5/      �� 50      .R�51      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   �� *	DateWrite+$ TwoWay=�$ PropertyChanged=�52      54      0  *System.Windows.Controls.DataGridTextColumn  55      $ Название��6%   $	 125 6i   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Balance.Medicine.MedicineName+   ElementStyle 56      �� 57      " ��6    .�58      ��  � ��$
 Wrap=�6=   59      5;        5<      $ Категория��6%   $	 200 6s    68   �� *(&Balance.Medicine.Category.NameCategory+ 5=      �� 5>      " ��6    .�5?      ��  � ��$
 Wrap=�6=   5@      5B        5C      $0 *Описание/форма выпуска��6%   $	 200 6v    6E   �� *Balance.Medicine.Description+ 5D      �� 5E      " ��6    .�5F      ��  � ��$
 Wrap=�6=   5G      5I        5J      -   5        Quan��$ Количество��5J   8   $	 115 6L    5K      �� 5L      .R�5M      �� ��6&   �� *QuantityWrite+$ TwoWay=�$ PropertyChanged=�5N      5P        5Q      -   5        
IdEmployee��$% Номер сотрудника��5Q   >   $	 115 6X    5R      �� 5S      .R�5T      �� ��6&   �� *
IdEmployee+$ TwoWay=�$ PropertyChanged=�5U      5W        5X      $% Причина списания��6%   $	 200 6Z    6?   �� *Reason+ 5Y      �� 5Z      " ��6    .�5[      ��  � ��$
 Wrap=�6=   5\      5^      5`      �� 5a   
   $��
Поиск��6   $��Center=�6    $��	20,15,0,0q�6=   $	��Top=�6P   $	��132��6h   $��Arial Narrow)�6t   $��22(�6�   �� 5b   
   -   5         ��Name$ tbSearh��5b      $��Center=�6#   $��0,60,0,0q�6A   $	��Top=�6S   $	��220��6k   $��30��6w    �� TextWrapping$
 Wrap=�6�   6�   �� 5c   
   $:��4Журнал списанных препаратов��6   $��Center=�66   $��	20,40,0,0q�6S   $	��Top=�6f   $	��534��6~   $��Arial Narrow)�6�   $��22(�6�   $��1��6�   �� 5d   
   $=��7Фильтр по категории препарата��6   $
��Wrap=�69   $��Center=�6M   $��0,13,0,0q�6j   $	��Top=�6|   $	��190��6�   $��Arial Narrow)�6�   $��22(�6�   $��1��6�   $��56��6�   �� 5e   
   -   5         ��Name$ 
cbCategory��5e       �� DisplayMemberPath$ NameCategory��6I   $��Center=�6k   $��0,74,0,0q�6�   $��1��6�   $��0��6�   $	��Top=�6�   $	��190��6�    �� SelectedItem 6'   �� *
Category+6�   �� 5f   
   -   5         ��Name$ 	btnSelect��5f      $��Выбрать��6$   #��[  66   $
��Left=�6[   $��
10,0,0,353q�6�   $��1��6�   $��0��6�   �� 5g   
   -	   5        $ btnClear��5g      $��Очистить��6#   #��[  66   $
��Left=�6[   $��125,0,0,353q�6�   $��1��6�   $��0��6�   5h      5i      