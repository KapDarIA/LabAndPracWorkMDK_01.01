   M S B A M L   `   `   `  ����D  @LabWork28, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:LabWork28.WindowsLabWork28.Windows  5   	   +    %LabWork28.Windows.AuthorizationWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:LabWork28.Windows     5   	     � Title$  AuthorizationWindow��5   	   $	��450��6%   $	��800��62   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5       � 	Resources 5   
    �� 
TargetType �� Property �� Value��%  '��       '�� w     '��     �� 5      " ��6   .�5      ��  � ��
 ��� �6/   �� 5       � ��$ Arial Black)�6/   5      �� 5      " ��6   .�5      ��  �@��	MaxLength$ 10��6.   �� 5       � ��$ 20(�6-   �� 5       � ��$ Arial Black)�6/   5      �� 5       " ��6   .�5!      ��  � ��$ 20��6+   �� 5"       � ��$	 100��6*   �� 5#       � ��$	 Top=�66   �� 5$       � ��
 �����6/   �� 5%       � ��$ 0 5 5 5q�6+   5&      5'      .+�5(   
   �� $��/Images/galaxy.jpg��6   $
��Left=�6,   $��Center=�6G   $��2��6b   �� 5*   
   -   5         ��Name$ 
LoginLabel��5*      $��Login��6$   �� 5+   
   -   5        $ PasswordLabel��5+      $��Password��6'   $��1��6:   �� 5-   
   -   5         ��Name$ LoginTextBox��5-      $��1��6(   $��Pacifico)�68   �� 5.   
   -   5        $ PasswordTextBox��5.      $��1��6+   $��1��68   $��Pacifico)�6H   �� 50   
   $��2��6   $��1��6"   	 �� Orientation$	 
Horizontal=�62   .+�51      �� -   5        
 ��Name$
 OKButton��51      $��OK��6'   �� 52      -   5        $
 CancelButton��52      $��Cancel��6+      CancelButton#��[  6<   53      54      55      