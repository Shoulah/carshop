   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   F BCarParts003, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CarParts003CarParts003 5	   	   7 clr-namespace:CarParts003.ModelsCarParts003.Models 5
      =#clr-namespace:CarParts003.ModelViewCarParts003.ModelView 5         CarParts003.AddCarWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   +localclr-namespace:CarParts003     5	   	   /vm clr-namespace:CarParts003.Models     5
      2VM#clr-namespace:CarParts003.ModelView     5        � Title$  Add Car��5   	   $��306.303��6   $��744.538��6*    � 
ResizeMode$ NoResize=�6:    � WindowStartupLocation$ CenterScreen=�6P    � 	Resources 5      )  #CarParts003.ModelView.MainModelView   K1��%   &	          5   
   6   5      .��5      �  J� RenderTransformOrigin$ 
0.48,0.484&�6    � ColumnDefinitions 5   
   �� 5      $
��300* �6   �� 5      $
��162* �6   �� 5      $
��277* �6   .+�5   
   �� $��Name:��6   $
��Left=�6    $��	65,39,0,0q�6;   $	��Top=�6N   $��70��6f   $��14(�6q   �� 5   
   $��Desc 1:��6   $
��Left=�6"   $��	65,73,0,0q�6=   $	��Top=�6P   $��70��6h   $��14(�6s   �� 5   
   $��Desc 2:��6   $
��Left=�6"   $��
65,102,0,0q�6=   $	��Top=�6Q   $��70��6i   $��14(�6t   �� 5   
   $��Desc 3:��6   $
��Left=�6"   $��
65,136,0,0q�6=   $	��Top=�6Q   $��70��6i   $��14(�6t   �� 5   
   $��Desc 4:��6   $
��Left=�6"   $��
65,170,0,0q�6=   $	��Top=�6Q   $��70��6i   $��14(�6t   �� 5   
   -   5         ��Name$ NameEditBox��5      $
��Left=�6'   $��18��6B   $��
140,37,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��526��6�   $��14(�6�   $��3��6�   ��6�   �� *dataModel.myName+ �� Mode$ TwoWay=�	 �� NotifyOnSourceUpdated	 . 
 �� NotifyOnValidationError
 .  �� Source# [   �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  �� ValidatesOnExceptions . �� 5   
   -   5        $ Desc4EditBox��5      $
��Left=�6(   $��18��6C   $��140,170,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��526��6�   $��14(�6�   $��3��6�   ��6�   �� *dataModel.myDesc4+# [  �� 5   
   -   5        $ Desc1EditBox��5      $
��Left=�6(   $��23��6C   $��
140,73,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   ��6�   �� *dataModel.myDesc1+$ TwoWay=�	 . 
 . # [  $ PropertyChanged=� .  . (  "System.Windows.Controls.DatePicker  5    
   -   5          Name$ dateTimePicker1��5       $
��Left=�6.   $��140,105,0,0q�6I   $	��Top=�6^   $	��120��6v      DisplayDate 6�   �� *dataModel.myDesc2+# [  �� 5!   
   -   5         ��Name$ 	CheckBox1��5!      $�� ��6&   $
��Left=�61   $��140,142,0,0q�6L   $	��Top=�6a    d� 	IsChecked 6y   �� *dataModel.myDesc3+# [  �� 5"   
   $
��Save��6   $
��Left=�6    $��135,218,0,0q�6;   $	��Top=�6P   $��75��6h   $��14(�6s   $��2��6�   ��6�   �� *saveCarCommand+$ TwoWay=� �� NotifyOnTargetUpdated . 	 . 
 . # [  $ PropertyChanged=� .  . �� 5#   
   -   5         ��Name$ DismissButton��5#      $��Dismiss��6(   $
��Left=�6:   $��
35,218,0,0q�6U   $	��Top=�6i   $��75��6�   $��14(�6�   $��2��6�   5%      5&      