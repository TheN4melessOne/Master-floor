   M S B A M L   `   `   `  ����G  CMaster-floor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Master_floorMaster_floor  5           Master_floor.MaterialsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Master_floor     5        N� Title$  MaterialsPage��5	       N� 
FontFamily$ Segoe UI)�6   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   .+�5   
   �� $��0��6   $��0��6"   .+�5      �� $��Тип продукции��6   6/   �� 5      -   5         ��Name$ ProdTypeBox��5      6.   5      �� 5   
   $��0��6   $��1��6"   .+�5      �� $��Тип материала��6   6/   �� 5      -   5        $ MaterialTypeBox��5      62   5      �� 5   
   $��1��6   $��0��6#   .+�5      �� $��Параметр 1��6   6,   �� 5       -   5         ��Name$
 Val1��5       6&   5!      �� 5"   
   $��1��6   $��1��6#   .+�5#      �� $��Параметр 2��6   6,   �� 5$      -   5        $
 Val2��5$      6&   5%      �� 5&   
   $��2��6   $��0��6"   .+�5'      �� $-��'Количество продукции��6   66   �� 5(      -   5        $ ProdAmountBox��5(      6/   5)      �� 5*   
   $��2��6   $��1��6"   .+�5+      �� $F��@Количество необходимого материала��6   6C   �� 5,      -   5         ��Name$ MaterialAmountBox��5,      65   5-      �� 5.   
   -   5         ��Name$ 	Calculate��5.   &   $��Рассчитать��6   $��2��6Q   $��3��6e   $��Bottom=�6r   $��Center=�6�   6�   5/      50      