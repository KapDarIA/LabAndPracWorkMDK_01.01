   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  Graphic Editor��5   	   $	��450��6    $	��800��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5         ��Name$ 	inkCanvas��5      $��1��6'    �� 
Background
 �����64   �� 5   
   $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5        $��
Load Image��5      $��Right=�6B   �� 5      -   5         ��Name$ ColorComboBox��5       �� SelectedIndex$ 0��6/   .@�5      �� $��Black��6   �� 5      $
��Pink��6   �� 5      $	��Red��6   �� 5      $��Green��6   �� 5      $��Yellow��6   5      �� 5      -   5         ��Name$ SizePenTextBlock��5      $��Размер(1):��62   �� 5      -   5         ��Name$ PenSizeSlider��5      	 � Minimum$	 1Q�6,   
 � Maximum$
 10Q�68    � Value$ 1Q�6E   $	��100��6O   6[   5      5      5      