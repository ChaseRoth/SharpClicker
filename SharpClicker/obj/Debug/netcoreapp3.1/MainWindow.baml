   M S B A M L   `   `   `  ����G  CSharpClicker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SharpClickerSharpClicker  5   	       SharpClicker.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:SharpClicker     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��300��6)    � DataContext 5
         SharpClicker.MainWindowVM  5   
    � 	Resources 5       �� 
TargetType �� Property �� Value�� 5   
   %�   '��       '�� j     �� 5      " ��6   .�5      ��  � ��$ 5q�6+   �� 5       � ��$ 1��60   5      �� 5      " ��6   .�5      ��  � ��$ 1��60   �� 5       � ��$
 70,5q�6+   5      5      .��5      � $��10q�6    � ColumnDefinitions 5   
   �� 5      $
��0.6* �6   �� 5      $��* �6    � RowDefinitions 5!   
   �� 5"      $��30 �6   �� 5#      $��30 �6   �� 5$      $��30 �6   �� 5%      $��30 �6   �� 5&      $��30 �6   �� 5'      $��30 �6   .+�5+   
   �� $��	Max Speed��6   �� 5,   
    � Minimum$
 0.66Q�6   	 � Maximum$
	 1000Q�6    
 � Value
 6/   �� *
Interval+�� 5/   
   $��	Min Speed��6   $��1��6$   �� 50   
   $
 0.66Q�6   $
	 1000Q�6    $��1��6/   
 6<   �� *Range+�� 53   
   $��Hotkeys��6   $��2��6"   $��2��6/   $��15(�6C   $��Center=�6Q   �� 56   
   $��
Toggle Key��6   $��3��6%   �� 57   
   -   5        $��?��57      $��3��6   6*   �� 5:   
   $��Self Destruct Key��6   $��4��6,   �� 5;   
   -   5        $��?��5;      $��4��6   6*   �� 5>   
   $	��CPS��6   $��5��6   �� 5?   
   $��5��6(   $��1��65   ��6   �� *CPS+65   5@      5A      