   M S B A M L   `   `   `  ����a  ]WPF - Property Data and Event Triggers, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:WPF___Property_Data_and_Event_Triggers&WPF___Property_Data_and_Event_Triggers  5   	   7    1WPF___Property_Data_and_Event_Triggers.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:WPF___Property_Data_and_Event_Triggers     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� .+�5
   
   � .+�5      �� $��Hello��6   $��30(�6%   $��Center=�63   $��Center=�6P   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 � � �6G    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5   "   ��  � ��
 �  ��6M   �� 5   "    � ��$ 	Underline{�6D   6X   5      5      5      5      � 5   
   .+�5      �� $��Darkness��6   $��24(�6(   $��Center=�66   $��Center=�6S   ��5      �� 5      " ��6    5      :� 5       :� RoutedEvent$ 
MouseEnter��6+   [�5   "   �� 5    &   .��5!   *   �� .��5"   .   W�  g� Duration$ 	0:0:0.500D�6>   	 �� TargetProperty$	 FontSize�6S   	
 W� To$
 72X�6x   5#   +   5$   '   5&      :� 5'      $ 
MouseLeave��6+   [�5(   "   �� 5)   &   .��5*   *   �� .��5+   .   W� $ 	0:0:0.300D�6>   $	 FontSize�6S   $
 24X�6x   5,   +   5-   '   5/      52      55      57      �� 58   
   .+�59      �� -   5        $
��cbCB��59      $��Are You My Old Friend?��6#   $��Center=�6D   $��Center=�5:      $��24(�62   �� 5;      $��Center=�6   $��22(�65   ��5<      �� 5=      " ��6   .�5>      ��  � ��$ No��61   �� 5?       � ��
 �  ��67    5@      �� 5A       �� Binding 6*   ��  �� ElementName$
 cbCB�� �� Path$ 	IsChecked� �� Value True6_   .a�5B   "   ��  � ��$ 	Of Course��69   �� 5C   "    � ��
 � � �6?   5D      5F      5H      5J      5K      5L      