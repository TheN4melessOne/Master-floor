   M S B A M L   `   `   `  ����G  CMaster-floor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Master_floorMaster_floor  5          Master_floor.PartnersPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Master_floor     5        N� Title$  PartnersPage��5	       N� 
FontFamily$ Segoe UI)�6   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $��* �6   6)   �� 5      $
��auto �6   6,   .+�5   
   �� $%��СПИСОК ПАРТНЕРОВ��6   $��Center=�6,   6K   �� 5   
   -   5         ��Name$ PartnerList��5   D   $��Stretch=�6   $��1��67    �� SelectionMode$ Single=�6Y   ��5      �� 5      .R�5      � ���#F4E8D3 � ColumnDefinitions 5      �� 5      61   �� 5      61    5      �� 5      6.   �� 5      6.   .+�5      ��  �� Orientation$ 
Horizontal=�6%   $��0��6>   $��0��6K   .+�5      �� ��6(   �� *PartTypes.typeName+6O   �� 5       $	�� | ��6(   65   �� 5!      ��6(   �� *
partName+6D   5"      �� 5#      $��0��6%   $��1��62   $ 
Horizontal=�6B   $��Right=�6[   $��0 0 50 0q�6w   .+�5$      ��  ��Name$ Percent��6(   ��69   �� *
discount+6U   �� 5%      $��%��6(   63   5&      �� 5'      $��1��6%   $��0��62   .+�5(      �� ��6(   �� *
director+6E   �� 5)      ��6(   �� *
phoneNum+6D   �� 5*      ��6(   �� *rating+6B   5+      5,      5-      5/      �� 50   
   -   5         ��Name$ PartnerInfo��50      $%��Создать партнера��6@   $��2��6[   $��Center=�6h   6�   51      52      