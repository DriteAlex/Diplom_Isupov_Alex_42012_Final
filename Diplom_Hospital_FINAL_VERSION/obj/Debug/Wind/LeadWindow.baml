   M S B A M L   `   `   `  ����J  FDiplom_Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Diplom_HospitalDiplom_Hospital  5   	        Diplom_Hospital.LeadWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Diplom_Hospital     5   	     � Title$X  R'KolomnaCRB' Система учета медицинских препаратов��5   	   $	��650��6C   $
��1200��6S    � WindowStyle$ SingleBorderWindow=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 	Resources 5         ButtonStyle �� 
TargetType �� Property �� Value��%9  &	        �� 5   
   " ��6$   .�5      ��  � ��$ 16(�6)   �� 5       � ��$ Arial Narrow)�6+   �� 5       � ��$	 100��6&   �� 5       � ��$ 25��6'   �� 5       � ��$ 20q�6'   �� 5       � ��
 ��� �6+   �� 5       � ��
 �����6+   5      5      .��5      �� 
����� �$��10q�6'   ._�5   
   �  � RowDefinitions 5      �� 5      �� 5      $
��231* �6    �� 5      $	��80* �6     � ColumnDefinitions 5      �� 5       $
��250* �6#   �� 5!      $
��871* �6#   �� 5"      $	��69* �6#   .+�5%       � -   5        	  �Name$	 	MainFrame��5%      
�������
  � NavigationUIVisibility$
 Hidden=�6>   $��1��6^   $��
0,49,68,57q�6k   $��1��6   $��2��6�   $��2��6�   �� 5'      -   5         ��Name$ 	btnOrders��5'      $)��#Заказ медикаментов��6(   #��[  6E   $	��Top=�6j   $��1��6�   $��	0,100,0,0q�6�   $��Center=�6�   $	��139��6�   �� 5(      -   5        $ btnMakeReceipts��5(      $ ��Оприходывание��6.   #��[  6F   $	��Top=�6k   $��1��6�   $��	0,143,0,0q�6�   $��Center=�6�   $	��139��6�   �� 5)      -   5        $ btnLogOfReceipts��5)      $)��#Журнал поступления��6/   #��[  6L   $	��Top=�6q   $��1��6�   $��	0,297,0,0q�6�   $��Center=�6�   $	��139��6�   �� 5*      -   5        $ btnLogWriteOff��5*      $#��Журнал списания��6-   #��[  6G   $	��Top=�6l   $��1��6�   $��Center=�6�   $	��139��6�   $��	0,349,0,0q�6�   �� 5+      -   5        $ btnMainPage��5+      $��На главную��6*   #��[  6?   $	��Top=�6d   $��2��6|   $��Center=�6�   $	��139��6�   $��0,75,0,0q�6�   5.      5/      50      