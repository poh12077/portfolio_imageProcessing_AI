   M S B A M L   `   `   `  ����H  DConfiguration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ConfigurationConfiguration  5      "    Configuration.NetworkTabView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Configuration     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Storage Servers��6   $��10q�6,   $
��auto��68   $
��auto��6E   
�������$��0��6f   .��5      ]� ��.  .+�5      �� $	��Top=�6   $��10q�64   $
��auto��6@   $
��auto��6M   $
��Auto=�6[   $
��Auto=�6�   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ storageServers��5      $	��100��68   ��6E   ��  �� Path$. (ModelProperty.StorageServerTableProperty� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5      �� $1 +ModelProperty.SelectedStorageServerProperty�$ TwoWay=�$ PropertyChanged=�   Columns 5      5      5      ]� 5      ��.  $��Bottom=�62   .+�5      �� $
��Left=�6!    �� Orientation$ 
Horizontal=�67   $��10q�6P   .+�5      �� $��Default Server : ��6$   $
��auto��6=   $
��auto��6J   $��Center=�6X   $��5q�6s   $��18(�6~   �� 5        �� 
IsEditable . $	��100��65   $
��auto��6A   $��5q�6O   	 w� TextPath$	 Alias��6Z   ��5!   #   �� $. (ModelProperty.StorageServerTableProperty�$ TwoWay=�$ PropertyChanged=� 5"   #   �� $1 +ModelProperty.SelectedStorageServerProperty�$ TwoWay=�$ PropertyChanged=���5#      �� 5$   "   .R�5%   &   �� ��60   �� $ Alias�5&   #   5(      �� 5)      $��	Echo Test��6!   $
��auto��65   $
��auto��6B   $��5q�6P   5*      �� 5+      $ 
Horizontal=�6!   $��Right=�6:   $��10q�6Q   .+�5,      �� $	��Add��6!   $��60��6/   $
��auto��6:   $��5q�6H   ��6T   �� *CommandStorageServerAdd+�� 5-      $��delete��6!   $��60��62   $
��auto��6=   $��5q�6K   5.      5/      51      52      �� 54   
   $��Worklist Servers��6   $��10q�6-   $
��auto��69   $
��auto��6F   
�������$��1��6g   .��55      ]� ��.  .+�56      �� $	��Top=�6   $��10q�64   $
��auto��6@   $
��auto��6M   $
��Auto=�6[   $
��Auto=�6�   .��57        -   5        $ worklistServers��57      $	��100��68   ��6E   �� $/ )ModelProperty.WorklistServerTableProperty�$ TwoWay=�$ PropertyChanged=� 58      �� $2 ,ModelProperty.SelectedWorklistServerProperty�$ TwoWay=�$ PropertyChanged=� 59      5>      5?      ]� 5A      $��Bottom=�6   ��.  .+�5B      �� $
��Left=�6!   $ 
Horizontal=�67   $��10q�6P   .+�5C      �� $��Default Server : ��6$   $
��auto��6=   $
��auto��6J   $��Center=�6X   $��5q�6s   $��18(�6~   �� 5D       . $	��100��65   $
��auto��6A   $��5q�6O   $	 Alias��6Z   ��5E   #   �� $/ )ModelProperty.WorklistServerTableProperty�$ TwoWay=�$ PropertyChanged=� 5F   #   �� $2 ,ModelProperty.SelectedWorklistServerProperty�$ TwoWay=�$ PropertyChanged=���5G      �� 5H   "   .R�5I   &   �� ��60   �� $ Alias�5J   #   5L      �� 5M      $��	Echo Test��6!   $
��auto��65   $
��auto��6B   $��5q�6P   5N      �� 5O      $ 
Horizontal=�6!   $��Right=�6:   $��10q�6Q   .+�5P      �� $	��Add��6!   $��60��6/   $
��auto��6:   $��5q�6H   ��6S   �� $ CommandWorklistServerAdd��� 5Q      $��delete��6!   $��60��62   $
��auto��6=   $��5q�6K   5R      5S      5T      5V      5Z      5[      