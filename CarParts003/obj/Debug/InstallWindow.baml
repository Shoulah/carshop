   M S B A M L   `   `   `  ����H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   F BCarParts003, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CarParts003CarParts003 5   	   =#clr-namespace:CarParts003.ModelViewCarParts003.ModelView 5         CarParts003.InstallWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   +localclr-namespace:CarParts003     5   	   2VM#clr-namespace:CarParts003.ModelView     5        � Title$  Add Install��5
   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[    � 	Resources 5      ,  &CarParts003.ModelView.InstallModelView   k2��%   &	          5   
   6   5      .��5      � .+�5   
    � -   5          �Name$
 Main��5        � NavigationUIVisibility$ Hidden=�6   �� 5   
   -   5         ��Name$ Button1��5      $��Cancel��6"   $
��Left=�63   $��425,378,0,0q�6N   $	��Top=�6c   $��75��6{   6�   �� 5   
   -   5        $
��Next��5      $
��Left=�6    $��515,378,0,0q�6;   $	��Top=�6P   $��75��6h    J� RenderTransformOrigin$ 0.474,-0.194&�6s   6�   �� 5   
   $��Button��6   $
��Left=�6"   $��610,378,0,0q�6=   $	��Top=�6R   $��75��6j   ��6u   �� *MyAddPartToListCommand+ �� Source# [  �� 5   
   $��Button��6   $
��Left=�6"   $��700,378,0,0q�6=   $	��Top=�6R   $��75��6j   ��6u   �� *MySaveInstallCommand+# [  �� 5   
   $
��Left=�6   $��23��6-   $��240,379,0,0q�69   	 �� TextWrapping$
	 Wrap=�6N   $	��Top=�6b   $	��170��6z   ��6�   �� *installPartModelw.PartName+# [  �� 5   
   $
��Left=�6   $��23��6-   $��
70,378,0,0q�69   $
	 Wrap=�6M   $	��Top=�6a   $	��155��6y   ��6�   �� *MyInstallModel.CarName+# [  5      5      