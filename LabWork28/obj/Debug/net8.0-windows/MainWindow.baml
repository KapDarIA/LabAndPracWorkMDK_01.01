   M S B A M L   `   `   `  ����D  @LabWork28, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:LabWork28	LabWork28  5   	       LabWork28.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:LabWork28     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��/Images/galaxy.jpg��6   $
��Left=�6,   $��Center=�6G   $��2��6b   �� 5   
   -   5         ��Name$ 
LoginLabel��5      $��Login��6$   $��./Fonts/#Montserrat Thin)�64   $��30(�6Z   �� 5   
   -   5        $ PasswordLabel��5      $��Password��6'   $��1��6:   $��./Fonts/#Montserrat Thin)�6G   $��30(�6m   �� 5   
   -   5         ��Name$ LoginTextBox��5      $��1��6(   $��./Fonts/#Montserrat Thin)�68   �� 5   
   -   5        $ PasswordTextBox��5      $��1��6+   $��1��68   $��./Fonts/#Montserrat Thin)�6H   �� 5   
   $��2��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5      �� -   5         ��Name$ OKButton��5      $��OK��6'   $��50��64   $	��100��6@   �� 5      -   5        $ CancelButton��5      $��Cancel��6+   $��50��6<   $	��100��6H      CancelButton#��[  6T   5      5!      5"      