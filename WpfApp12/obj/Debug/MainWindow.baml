   M S B A M L   `   `   `  ����C  ?WpfApp12, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp12WpfApp12  5   	       WpfApp12.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp12     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DtGrid��5
      $
��Left=�6#   $	��218��6>   $��143,134,0,0q�6K      AutoGenerateColumns .  $	��Top=�6|   $	��248��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Username��6B      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
Username+6T     5      $
 Name��6B   $ 80 6P    6%   �� *
Username+6P     5      $ Password��6B   $ 80 6T    6%   �� *
Username+6T   5      �� 5   
   -   5         ��Name$	 btn��5      $��Button��6   $
��Left=�6/   $��
320,60,0,0q�6J   $	��Top=�6^   $��75��6v   6�   �� 5   
   $
��Left=�6   $��25��6-   $��509,134,0,0q�69    �� TextWrapping$
 Wrap=�6N   $��TextBox��6b   $	��Top=�6q   $	��108��6�   �� 5   
   $
��Left=�6   $��25��6-   $��509,188,0,0q�69   $
 Wrap=�6N   $��TextBox��6b   $	��Top=�6q   $	��108��6�   �� 5   
   $
��Left=�6   $��25��6-   $��509,242,0,0q�69   $
 Wrap=�6N   $��TextBox��6b   $	��Top=�6q   $	��108��6�   	 J� RenderTransformOrigin$	 0.633,3.104&�6�   5      5      