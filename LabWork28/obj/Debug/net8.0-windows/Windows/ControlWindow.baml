   M S B A M L   `   `   `  ����D  @LabWork28, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LabWork28.WindowsLabWork28.Windows  5   	   %    LabWork28.Windows.ControlWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:LabWork28.Windows     5   	     � Title$  ControlWindow��5   	   $	��450��6   $	��800��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      $	��49* �6   �� 5      $
��151* �6   .+�5   
   �� -   5         ��Name$ 
LoginLabel��5      $��Login��6$   $��5,5,5,5q�64   �� 5   
   -   5        $ PasswordLabel��5      $��Password��6'   $��1��6:   $��5,5,5,5q�6G   �� 5   
   -   5         ��Name$ LoginTextBox��5      $��1��6(   $��5,5,5,5q�68   �� 5   
   -   5        $ PasswordTextBox��5      $��1��6+   $��1��68   $��5,5,5,5q�6H   �� 5   
   $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��	0,144,0,0q�6K   $��2��6^   .+�5      �� -   5         ��Name$ OKButton��5      $��OK��6'   $��50��64   $	��100��6@   �� 5      -   5        $ CancelButton��5      $��Cancel��6+   $��50��6<   $	��100��6H      CancelButton#��[  6T   �� 5      -   5        $ LightButton��5      $��Light��6*   $��50��6:   $	��120��6F   6R   �� 5      -   5        $ 
DarkButton��5      $
��Dark��6)   $��50��68   $	��120��6D   6P   5      5!      5"      