   M S B A M L   `   `   `  ����M  IManagement_Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Management_ProjectManagement_Project  5   	       Management_Project.Bill   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Management_Project     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
     � Title$  Create Bill��5      $	��620��6   $	��450��6)      MaterialDesignBody#���   5
      $��Regular"�5      $��13(�5      &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5         TextRenderingMode$
 Auto=�5        MaterialDesignPaper#���  5        MaterialDesignFont#���  5      .��5      � $��	0,0,0,-20q�6   .+�5   
   �� -   5        $��ID��5   �   $
��Left=�6   $��26��6-   $��
148,10,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6b   $	��230��6z   6�   �� 5   
   -   5        $	��Ten��5   �   $
��Left=�6   $��26��6-   $��
148,58,0,0q�69   $
 Wrap=�6M   $	��Top=�6a   $	��230��6y   6�   �� 5   
   -   5        $��List_Products��5   ]   $
��Left=�6   $��26��6.   $��48,121,0,463q�6:   $	��108��6Q   5      �� 5   
   -   5         ��Name$	 Qty��5   �   $
��Left=�6   $��26��6-   $��261,121,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $��43��6z   6�   �� 5   
   -   5        $��Total��5   �   $
��Left=�6   $��26��6-   $��123,532,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��158��6z    �� 
IsReadOnly . 6�   �� 5   
   $��Mã hóa đơn��6   $
��Left=�6%   $��26��6@   $��	23,22,0,0q�6L   $	��Top=�6_   $��90��6w    J� RenderTransformOrigin$ 0.533,0.346&�6�   �� 5   
   $��Tên khách hàng��6   $
��Left=�6)   $��26��6D   $��	23,67,0,0q�6P   $	��Top=�6c   $	��100��6{   �� 5   
   $��ID��6   $
��Left=�6   $��26��68   $��
10,121,0,0q�6D   $	��Top=�6X   $��55��6p   �� 5   
   -   5        $��ListProducts��5   J   $��0,147,0,174q�65   $��Disabled=�6^   ��6   �� *	ListItems+ �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$
 70px��6^   	 �� DisplayMemberBinding	 63   �� *	ProductID+6m   �� 5       $��Tên sản phẩm��6%   $ 150px��6c   	 6=   �� *Name+6s   �� 5!      $��Số lượng��6%   $ 100px��6^   	 69   �� *Qty+6n   �� 5"      $
��Giá��6%   $ 100px��6Z   	 64   �� *Cost+6j   5$      5&      �� 5'   
   $��Tổng Tiền��6   $
��Left=�6$   $��26��6?   $��
20,541,0,0q�6K   $	��Top=�6_   $	��103��6w   �� 5(   
   -   5        $��
CreateBill��5+   u     MaterialDesignRaisedButton#��[ 5)      $	��110��5*      
 � ToolTip$/
 )Resource name: MaterialDesignRaisedButton��5+      $��Tạo��6Q    � DataContext$ center;��6_   $��309,535,23,0q�6�   $	��Top=�6�   {�.  6�   �� 5,   
   -   5         ��Name$ 
AddProduct��5.   f   #��[ 5-      $/
 )Resource name: MaterialDesignRaisedButton��5.      $��Thêm��6A   $ center;��6P   $��330,116,10,463q�6z   $
��Auto��6�   {�.  6�   �� 5/   
   $��Số lượng��6   $
��Left=�6#   $��26��6>   $��174,121,0,0q�6J   $	��Top=�6_   $��66��6w   $ 0.758,0.615&�6�   �� 50   
   $��Trạng thái��6   $
��Left=�6%   $��26��6@   $��
20,484,0,0q�6L   $	��Top=�6`   $	��103��6x   $ 0.437,1.192&�6�   �� 51   
   -	   5        $ 	TrangThai��51   �   $
��Left=�6   $��26��6-   $��123,475,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��158��6z   6�   �� 52   
   -
   5        $ Delete��55   e   #��[ 53      $	��110��54      $/
 )Resource name: MaterialDesignRaisedButton��55      $
��Xóa��6A   $ center;��6O   $��309,484,23,0q�6u   $	��Top=�6�   {�.  6�   57      58      