   M S B A M L   `   `   `  ����G  CGropuProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:GropuProject.ViewsGropuProject.Views  5   	   "    GropuProject.Views.SellerSub   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:GropuProject.Views     5   	     � Title$  AdminSub��5   	   $	��550��6   $	��800��6'    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � AllowsTransparency$
 True��5   	   
������  � DataContext 5      $   GropuProject.Views.SellerSubVM  5   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   ��  �� CornerRadius$ 	30 0 0 30��6   ��5      �� 5       �� 
StartPoint$	 0 0&�6&    �� EndPoint$	 1 1&�67   .��5      � 	 � Color$	 #000c54��6#   
 � Offset$
 0Q�63   � 5      $	 #1C1C1C��6#   $
 1Q�63   5      ._�5      �� $��/IMG/WBG1.png��6   $��UniformToFill=�6+    J� Opacity$
 0.05Q�6C   5      &   System.Windows.Controls.DataGrid  5    
   $��1��6   
�������   AutoGenerateColumns$ False��6�   ��6>   �� *
Products+ �� SelectedItem 6_   �� *SelectedProduct+   Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5#      $ Product Name��6%   $ * 6W    6;   �� *	ProName+6W     5$      $ Product Price��6%   $ * 6Y    6<   �� *
ProPrice+6Y     5%      $ Product Quantity��6%   $
 auto 6_    6?   �� *ProQuantity+6_     5&      $ 	Sales Tax��6%   $ * 6U    68   �� *
SalesTax+6U      	CellStyle 5(      �� 5)       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5*      ��  �� Property � �� �� Value �#AFEEEE63   5+      5-      �� 50   
   .+�51      ��  �� Orientation$ 
Horizontal=�6   .+�52      �� $��Seller ID : ��6   ���#AFEEEE$��16(�6F    �� Padding$ 15q�6T   $��5q�6a   $	��149��6l   �� 53      $��16(�6   $	��10 q�6(   $��5q�65   $	��200��6A   ��6M   �� *Id+54      �� 58      $ 
Horizontal=�6   .+�59      �� $�� Product Name :��6   ���#AFEEEE$��16(�6H   $ 15q�6V   $��5q�6c   $	��150��6n   �� 5:      $��16(�6   $��10q�6(   $��5q�64   $	��202��6@   ��6L   �� *	ProName+5;      �� 5?      $ 
Horizontal=�6   .+�5@      �� $��Product Price  : ��6   ���#AFEEEE$��16(�6J   $ 15q�6X   $��5q�6e   $	��148��6p   �� 5A      $��16(�6   $��10q�6(   $��5q�64   $	��203��6@   ��6L   �� *
ProPrice+5B      �� 5C      $ 
Horizontal=�6   .+�5D      �� $��Product Quantity : ��6   ���#AFEEEE$��16(�6L   $ 15q�6Z   $��5q�6g   $	��148��6r   �� 5E      $��16(�6   $��10q�6(   $��5q�64   $	��203��6@   ��6L   �� *proQuantity+5F      �� 5G      $ 
Horizontal=�6   .+�5H      �� $��Sales Tax : ��6   ���#AFEEEE$��16(�6E   $ 15q�6S   $��5q�6`   $	��148��6k   �� 5I      $��16(�6   $��10q�6(   $��5q�64   $	��203��6@   ��6L   �� *
SalesTax+5J      �� 5M      $ 
Horizontal=�6   $��10q�62   .+�5N      �  � RowDefinitions 5O      �� 5P      $��1* �6(   �� 5Q      $��1* �6(   5S      �� 5T      $��0��6   $	��213��6*   .+�5U      �� $	��150��6   $��40��6)   $��16)�65   $��5q�6E   $��10q�6Q   
����ح�
����  �$��Center=�6�   $��Add Product��5V      ��6'   �� *AddProductCommand+�� 5W      $	��150��6   $��40��6)   $��16)�65   $��5q�6E   $��10q�6Q   
����ح�$��Center=�6u   
����  �$��Edit Product��5X      ��6(   �� *UpdateProductsCommand+5Z      �� 5\      $��1��6   .+�5]      �� $	��150��6   $��40��6)   $��16)�65   $��10q�6E   $��5q�6Q   
����ح�
����  �$��Delete Product��5^      $��Center=�6T   ��6*   �� *DeleteProductCommand+6T   �� 5_      $	��150��6   $��40��6)   $��16)�65   $��10q�6E   $��5q�6Q   
����ح�
����  �$��Read Product��5`      $��Center=�6P   ��6(   �� *ReadProductCommand+6P   5b      5f      �� 5h      $��1��6   .+�5k      �� -   5        $	��150��5k      $��40��6%   $��16)�61   $��5q�6A   
����ح�
����  �$��
Add Grades��5l      6*   �� 5o      -   5        $��78��5o      $��	10 25 0 0q�6$   $��26��67   $��16)�6C   $��5q�6S   
����ح�
����  �$
��Back��5p      6    5s      5w      5�      5�      