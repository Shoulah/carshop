   M S B A M L   `   `   `  ����F  BCarParts003, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CarParts003CarParts003  5   	   =#clr-namespace:CarParts003.ModelViewCarParts003.ModelView  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5	          CarParts003.AddPartWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CarParts003     5   	   2VM#clr-namespace:CarParts003.ModelView     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5	        � Title$  Add Part��5   	   $	��300��6   $	��696��6'    � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�6X    � 	Resources 5      -   'CarParts003.ModelView.PartMainModelView   K2��%   &	          5   
   6   5      .��5      �  J� RenderTransformOrigin$ 
0.48,0.484&�6    � ColumnDefinitions 5   
   �� 5      $
��462* �6   �� 5      $
��277* �6   .+�5   
   �� $��Name:��6   $
��Left=�6    $��	65,39,0,0q�6;   $	��Top=�6N   $��70��6f   $��14(�6q   �� 5   
   $��Desc 1:��6   $
��Left=�6"   $��	65,73,0,0q�6=   $	��Top=�6P   $��70��6h   $��14(�6s   �� 5   
   $��Desc 2:��6   $
��Left=�6"   $��
65,102,0,0q�6=   $	��Top=�6Q   $��70��6i   $��14(�6t   �� 5   
   $��Desc 3:��6   $
��Left=�6"   $��
65,136,0,0q�6=   $	��Top=�6Q   $��70��6i   $��14(�6t   �� 5   
   $��Desc 4:��6   $
��Left=�6"   $��
65,170,0,0q�6=   $	��Top=�6Q   $��70��6i   $��14(�6t   �� 5   
   $
��Left=�6   $��18��6-   $��
140,37,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6a   $	��526��6y   $��14(�6�   $��2��6�   ��6�   �� *MyPartDateModel.Name+ �� Source# [  �� 5   
   $
��Left=�6   $��18��6-   $��140,170,0,0q�69   $
 Wrap=�6N   $	��Top=�6b   $	��526��6z   $��14(�6�   $��2��6�   ��6�   �� *MyPartDateModel.Desc4+# [  �� 5   
   $
��Left=�6   $��23��6-   $��
140,73,0,0q�69   $
 Wrap=�6M   $	��Top=�6a   $	��120��6y   ��6�   �� *MyPartDateModel.Desc1+# [  (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dateTimePicker1��5      $
��Left=�6.   $��140,105,0,0q�6I   $	��Top=�6^   $	��120��6v   	   DisplayDate	 6�   �� *MyPartDateModel.Desc2+# [  �� 5   
   $�� ��6   $
��Left=�6   $��140,142,0,0q�69   $	��Top=�6N   
 d� 	IsChecked
 6f   �� *MyPartDateModel.Desc3+# [  �� 5   
   $
��Save��6   $
��Left=�6    $��160,218,0,0q�6;   $	��Top=�6P   $��75��6h   $��14(�6s   $��1��6�   ��6�   �� *53SavePartCommand.MyPartMainModelView.SavePartCommand+# [  �� 5   
   -   5         ��Name$ DismissButton��5      $��Dismiss��6(   $
��Left=�6:   $��
71,218,0,0q�6U   $	��Top=�6i   $��75��6�   $��14(�6�   $��1��6�   6�   5!      5"      