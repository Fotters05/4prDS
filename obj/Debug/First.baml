   M S B A M L   `   `   `  ����L  HPraktika1_DataSet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Praktika1_DataSetPraktika1_DataSet  5          Praktika1_DataSet.First   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Praktika1_DataSet     5        N� Title$  First��5	      .��5      � $��0,10,0,0q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ SushiDataGrid��5      $��0��6*   $��2��67   6K   �� 5   
   -   5        $#��Добавить данные��5      $��3��6D   $��0��6Q   $
��left=�6a   $	��Top=�6|   $��10q�6�   �� 5   
   -   5        $!��Удалить данные��5      $��3��6A   $��1��6N   $
��left=�6^   $	��Top=�6y   $��10q�6�   �� 5   
   -   5        $��Закрыть окно��5      $��3��6E   $��1��6R   $��right=�6b   $	��Top=�6~   $��10q�6�   �� 5   
   -   5        $#��Обновить данные��5      $��3��6:   $��1��6G   $��center=�6W   $	��Top=�6t   $��10q�6�   �� 5   
   -   5         ��Name$ NameTbx��5      $��1��6#   $��10q�60   $6��0Введите название сушибара��6<   �� 5   
   -   5        $ WorkingHourse��5      $��2��6)   $��10q�66   $,��&Введите время работы��6B   $��0��6^   �� 5   
   -   5        $ TitleTbx��5      $��1��6$   $��1��61   $��10q�6A   $B��<Введите  новое название сушибара��6M   �� 5    
   -	   5        $ WH��5       $��2��6   $��2��6+   $��10q�6;   $H��BВведите новое время работы сушибара��6G   5"      5#      