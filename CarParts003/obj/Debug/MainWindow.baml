   M S B A M L   `   `   `  ����F  BCarParts003, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CarParts003CarParts003  5   	   =#clr-namespace:CarParts003.ModelViewCarParts003.ModelView  5   	       CarParts003.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CarParts003     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null:dg1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ,VM#clr-namespace:CarParts003.ModelView  5   	   l hTelerik.Windows.Controls.Input, Version=2018.3.1016.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7f bTelerik.Windows.Controls, Version=2018.3.1016.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Atelerik1http://schemas.telerik.com/2008/xaml/presentation   5
   	   -   5          � Title$  
MainWindow��5   	   $	��430��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65    � WindowStyle$
 None=�6Z    � 
ResizeMode$ CanResizeWithGrip=�6m   $��Stretch=�6�   $	��800��6�   $	��430��6�    � 	Resources 5      )   #CarParts003.ModelView.MainModelView   K1-   'CarParts003.ModelView.PartMainModelView  K2,   &CarParts003.ModelView.InstallModelView  K3.   (CarParts003.ModelView.ConstInfoModelView  K4��%t   &	        &	      &	 &     &	 9       5   
   6     5   
   6     5   
   6     5   
   6    5      .��5      � ���	#FF35203B J� OpacityMask �	#FF588F27$
��Auto=�6:   .+�5   
   � -   5         �Name$ MainGrid��5      $��Center=�6!   $��70��6>   $��0,0,0,0q�6J   $	��Top=�6[   ���	#FF35203B$	��801��6�   .+�5      �� -   5         ��Name$ xx��5      $��55(�6$   $��Center=�62   $��	Car Parts��6O   $��Center=�6`   ���	#FFFFF4E06{   5      � 5   
   $	��350��6   $��0,70,0,0q�6   $	��250��6.   ���	#FF35203B$	��Top=�6Q   $
��Left=�6i   .+�5      �� -   5         ��Name$ 
MyListView��5      ��6+   Z� ��6A   Z� .@�5      �� -   5        	 ��Name$	 AddcarListItem��5      
 �� Orientation$
 
Horizontal=�65   $	��230��6O   ��5      �� 5       �� Color$ Black��6*    �� Opacity$ 0Q�68   .+�5       '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$	 Car=�6"   $��40��6-   $��40��68   $��20 20q�6D   $��Center=�6T   ���	#FFFFF4E06o   �� 5!      $��Add Car��6    $
��30 0q�6/   $��24(�6=   $��Center=�6K   ���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6}   $
��Bold"�6�   5#      �� 5%      -   5        $	 AddPartListItem��5%      $
 
Horizontal=�66   $	��230��6O   ��5&      �� 5'      $ Black��6*   $ 0Q�68   .+�5)        $ Toolbox=�6"   $��40��61   $��40��6<   $��20 20q�6H   $��Center=�6X   ���	#FFFFF4E06s   �� 5*      $��Add Part��6    $
��30 0q�60   $��24(�6>   $��Center=�6L   ���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6~   $
��Bold"�6�   5+      �� 5,      -   5        $	 Install��5,   B   $
 
Horizontal=�6   $	��230��66   .+�5-        $ Garage=�6"   $��40��60   $��40��6;   $��20 20q�6G   $��Center=�6W   ���	#FFFFF4E06r   �� 5.      $��Install Wizard��6    $
��30 0q�66   $��24(�6D   $��Center=�6R   ���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $
��Bold"�6�   5/      �� 50      -   5        $
 
Horizontal=�50      $	��230��66   .+�51        $ Report=�6"   $��40��60   $��40��6;   $��20 20q�6G   $��Center=�6W   ���	#FFFFF4E06r   �� 52      $��	Reporting��6    $
��30 0q�61   $��24(�6?   $��Center=�6M   ���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6   $
��Bold"�6�   53      �� 54      -	   5        $
 
Horizontal=�54      $	��230��66   .+�55        $ Settings=�6"   $��40��62   $��40��6=   $��20 20q�6I   $��Center=�6Y   ���	#FFFFF4E06t   �� 56      $��Informations��6    $
��30 0q�64   $��24(�6B   $��Center=�6P   ���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $
��Bold"�6�   57      58      59      � 5:   
   $��
250,70,0,0q�6   ���	#FFFFF4E0.+�5<      �� -
   5         ��Name$ MyControlTab��5<   D   $��0q�6   ���	#FF35203B$
��Left=�6Z   $	��Top=�6u    5=       �� 
TargetType �� Property �� Value �� 
TargetType��%r   '��       �� 5?      " ��6   .�5A      ��  � �� 5C      �� 5E   "   " ��62   5I      5K      5M      ��5O      �� 5P      $ 	#FFF9F9F9��6&   $ 0Q�68   .@�5R      �� -   5         ��Name$ MainTab��5R      $
��Left=�6+   $	��Top=�6F   .��5S      � $
��Left=�6   $	��Top=�66   5T      �� 5U      -   5        $ 	AddCarTab��5U      .��5V      � .+�5W      �� $��Add Car Details��6    $
��Left=�6:   $��
185,10,0,0q�6U   $	��Top=�6i   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��22(�6�   $
��Bold"�6�   �� 5X      $��Name:��6    $
��Left=�60   $��	36,65,0,0q�6K   $	��Top=�6^   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5Y      $��Number:��6    $
��Left=�62   $��
36,110,0,0q�6M   $	��Top=�6a   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5Z      $��Date:��6    $
��Left=�60   $��
36,154,0,0q�6K   $	��Top=�6_   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5[      $��MyBool:��6    $
��Left=�62   $��
38,201,0,0q�6M   $	��Top=�6a   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   $��31��6�   �� 5\      $��Desc:��6    $
��Left=�60   $��
36,253,0,0q�6K   $	��Top=�6_   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5]       �� TextWrapping$
 Wrap=�6"   $��127,58,26,244q�66   $��18(�6M   ���	#89000000��6s   �� *dataModel.myName+ �� Mode$ TwoWay=� �� NotifyOnValidationError .  �� Source# [   �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors .  �� ValidatesOnExceptions . �� 5^      $
 Wrap=�6"   $��127,244,26,56q�66   $��18(�6M   ��6[   �� *dataModel.myDesc4+# [  �� 5_      $
 Wrap=�6"   $��127,101,291,199q�66   $��18(�6O   ��6]   �� *dataModel.myDesc1+$ TwoWay=� . # [  $ PropertyChanged=� .  . �� 5`      $�� ��6#   $
��Left=�6.   $��127,206,0,0q�6I   $	��Top=�6^   $��18(�6v    d� 	IsChecked 6�   �� *dataModel.myDesc3+# [  (  "System.Windows.Controls.DatePicker  5a      $
��Left=�6%   $��127,160,0,0q�6@   $	��Top=�6U   $	��124��6m      DisplayDate 6y   �� *dataModel.myDesc2+$ TwoWay=�# [  $ PropertyChanged=��� 5b      $
��Save��6!   $
��Left=�60   $��441,308,0,0q�6K   $	��Top=�6`   $��75��6x   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6  ��61  �� *saveCarCommand+# [  �� 5c      -   5        $
��Back��5c   !   $
��Left=�60   $��
36,308,0,0q�6K   $	��Top=�6_   $��75��6w   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6  60  5e      5f      �� 5g      -   5        $ 
AddPartTab��5g      .��5h      � .+�5j      �� $��Add Part Details��6    $
��Left=�6;   $��
185,10,0,0q�6V   $	��Top=�6j   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��22(�6�   $
��Bold"�6�   �� 5k      $��Name:��6    $
��Left=�60   $��	36,65,0,0q�6K   $	��Top=�6^   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5l      $��Number:��6    $
��Left=�62   $��
36,110,0,0q�6M   $	��Top=�6a   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5m      $��Date:��6    $
��Left=�60   $��
36,154,0,0q�6K   $	��Top=�6_   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5n      $��MyBool:��6    $
��Left=�62   $��
38,201,0,0q�6M   $	��Top=�6a   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   $��31��6�   �� 5o      $��Desc:��6    $
��Left=�60   $��
36,253,0,0q�6K   $	��Top=�6_   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5p      $
 Wrap=�6"   $��127,58,26,244q�66   $��18(�6M   ���	#89000000��6s   �� *partDateModel.Name+$ TwoWay=� . # [ $ PropertyChanged=� .  . �� 5q      $
 Wrap=�6"   $��127,244,26,56q�66   $��18(�6M   ��6[   �� *partDateModel.Desc4+# [ �� 5r      $
 Wrap=�6"   $��127,101,291,199q�66   $��18(�6O   ��6]   �� *partDateModel.Desc1+$ TwoWay=� . # [ $ PropertyChanged=� .  . �� 5s      $�� ��6#   $
��Left=�6.   $��127,206,0,0q�6I   $	��Top=�6^   $��18(�6v    6�   �� *partDateModel.Desc3+# [   5t      $
��Left=�6%   $��127,160,0,0q�6@   $	��Top=�6U   $	��124��6m    6y   �� *partDateModel.Desc2+$ TwoWay=� . # [ $ PropertyChanged=� .  . �� 5u      $
��Save��6!   $
��Left=�60   $��441,308,0,0q�6K   $	��Top=�6`   $��75��6x   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6  ��61  �� *SavePartCommand+# [ �� 5v      -   5        $
��Back��5v   !   $
��Left=�60   $��
36,308,0,0q�6K   $	��Top=�6_   $��75��6w   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6  60  5x      5y      �� 5{      .��5|      �� -   5        $ InstallTabControl��5|   L   $��0q�6!   ���	#FF35203B 5}      ��%r   '��       �� 5      " ��6$   .�5�   "   ��  � �� 5�   &   �� 5�   *   " ��6:   5�   #   5�      5�      ��5�      �� 5�      $ 	#FFF9F9F9��6.   $ 0Q�6@   .@�5�      �� .��5�      � .+�5�   "   �� $��
Select Car��6(   $
��Left=�6=   $��
185,10,0,0q�6X   $	��Top=�6l   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��22(�6�   $
��Bold"�6�   �� 5�   "   -   5        $��	Add Parts��5�   )   $
��Left=�6=   $��425,288,0,0q�6X   $	��Top=�6m   $��99��6�   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6,  6>  �� 5�   "   -   5        $
��Back��5�   )   $
��Left=�68   $��
10,288,0,0q�6S   $	��Top=�6g   $��75��6   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6&  68  1  +Telerik.Windows.Controls.RadAutoCompleteBox  5�   "   $��132,65,10,218q�6=      SelectionMode$ Single=�6�   $<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��24(�6�   ���	#FF35203B���	#FF35203B   ItemsSource 6T   �� *searchModel.MyNames+# [    SelectedItem 68  �� *MyInstallModel.CarName+$ TwoWay=�# [ $ PropertyChanged=��� 5�   "   $��Select Car:��6(   $
��Left=�6>   $��	10,65,0,0q�6Y   $	��Top=�6l   $	��117��6�   $��37��6�   $<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��24(�6�   $
��Bold"�6�   ���	#FF35203B6  5�      5�      �� 5�      .��5�      � .+�5�   "   �� $��	Add Parts��6(   $
��Left=�6<   $��
185,10,0,0q�6W   $	��Top=�6k   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��22(�6�   $
��Bold"�6�     5�   "   $��132,65,10,218q�6=   $ Single=�6�   $<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��24(�6�   ���	#FF35203B���	#FF35203B 6T   �� *searchModel.MyParts+# [  68  �� *installPartModelw.PartName+$ TwoWay=�# [ $ PropertyChanged=��� 5�   "   $
��Save��6)   $
��Left=�68   $��449,288,0,0q�6S   $	��Top=�6h   $��75��6�   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6'  ��69  �� *MySaveInstallCommand+# [ �� 5�   "   $	��Add��6)   $
��Left=�67   $��458,131,0,0q�6R   $	��Top=�6g   $��56��6   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��12(�6  $
��Bold"�6&  $��23��6  ��68  �� *MyAddPartToListCommand+# [ 6  �� 5�   "   -   5        $
��Back��5�   )   $
��Left=�68   $��
10,288,0,0q�6S   $	��Top=�6g   $��75��6   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6&  68  �� 5�   "   $��Select Part:��6(   $
��Left=�6?   $��	10,65,0,0q�6Z   $	��Top=�6m   $	��117��6�   $��37��6�   $<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��24(�6�   $
��Bold"�6�   ���	#FF35203B6  �� 5�   "   $
 Wrap=�6*   $��137,107,79,163q�6>   $��18(�6V   ���	#89000000��6|   �� *installPartModelw.PartDesc+$ TwoWay=�# [ $ PropertyChanged=��� 5�   "   $��Desc:��6(   $
��Left=�68   $��
15,119,0,0q�6S   $	��Top=�6g   $	��117��6   $��37��6�   $<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��24(�6�   $
��Bold"�6�   ���	#FF35203B6�   5�      5�      5�      5�      �� 5�      .��5�      � .+�5�      �� $��Reports��6    $
��Left=�62   $��
235,10,0,0q�6M   $	��Top=�6a   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��22(�6�   $
��Bold"�6�   �� 5�      $��110,111,312,129q�6!   $	��100��6:   $	��120��6G   ��6S   Z� ��6j   Z� ��5�      �� 5�   "   $ Black��62   $ 0Q�6@   .��5�        $ Report=�6*   $	��100��68   $	��100��6D   ���	#FF35203B$��Center=�6h   $��Center=�6�   5�      �� 5�      $	��100��6!   $	��120��6.   $��312,111,110,129q�6g   ��6:   Z� ��6Q   Z� ��5�      �� 5�   "   $ Black��62   $ 0Q�6@   .��5�        $ Report=�6*   $	��100��68   $	��100��6D   ���	#FF35203B$��Center=�6h   $��Center=�6�   5�      �� 5�      $��Report 2��6    $
��Left=�63   $��347,216,0,0q�6N   $	��Top=�6c   $��73��6{   $<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   ���	#FF35203B$
��Bold"�6�   �� 5�      $��Report 1��6    $
��Left=�63   $��134,216,0,0q�6N   $	��Top=�6c   $��73��6{   $<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   ���	#FF35203B$
��Bold"�6�   �� 5�      -   5        $
��Back��5�   !   $
��Left=�60   $��
36,308,0,0q�6K   $	��Top=�6_   $��75��6w   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6  60  5�      5�      �� 5�      .��5�      � .+�5�      �� $��Constant informations��6    $
��Left=�6@   $��
171,10,0,0q�6[   $	��Top=�6o   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��22(�6�   $
��Bold"�6�   �� 5�      $
��Left=�6    $	��145��6;   $��
171,42,0,0q�6H   $	��Top=�6\   $	��182��6t     J� IsHitTestVisible  . ��6�   �� *!constInfoModel.ImageSourceConst+! �� IsAsync! . $ TwoWay=� . # [ $ PropertyChanged=� .  . 6e  �� 5�      $��Info:��6    $
��Left=�60   $��
10,192,0,0q�6K   $	��Top=�6_   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5�      $��
More info:��6    $
��Left=�65   $��
10,271,0,0q�6P   $	��Top=�6d   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5�      $��Date:��6    $
��Left=�60   $��
10,240,0,0q�6K   $	��Top=�6_   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��18(�6�   $
��Bold"�6�   �� 5�      -   5        $
��Back��5�   !   $
��Left=�60   $��
10,308,0,0q�6K   $	��Top=�6_   $��75��6w   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6  60  �� 5�      $
��Save��6!   $
��Left=�60   $��441,308,0,0q�6K   $	��Top=�6`   $��75��6x   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6  ��61  �� *MyConstSaveCommand+# [ �� 5�      $	��...��6!   $
��Left=�6/   $��
441,42,0,0q�6J   $	��Top=�6^   $��40��6v   ���	#FF35203B���	#FF35203B���	#FFFFF4E0$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6�   $��16(�6  $
��Bold"�6  $��22��6/  ��6;  �� *updateImageCommand+# [ �� 5�      $
 Wrap=�6"   $��101,192,10,108q�66   $��18(�6N   ��6\   �� *constInfoModel.InfoString+$ TwoWay=� . # [ $ PropertyChanged=� .  . �� 5�      $
 Wrap=�6"   $��101,263,10,37q�66   $��18(�6M   ��6[   �� *constInfoModel.MoreInfoe+$ TwoWay=� . # [ $ PropertyChanged=� .  .   5�      $
��Left=�6%   $��101,240,0,0q�6@   $	��Top=�6U   $	��142��6m   "   SelectedDate" 6y   �� *constInfoModel.InfoDate+# [ 5�      5�      � 5�      $��90��6   $��96��6#   � 5�      $	��100��6   $	��100��6$   �� 5�      $��Add Car��6   $
��Left=�6*   $	��Top=�6E   $��73��6]   $<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6h   $��18(�6�   ���	#FF35203B$
��Bold"�6�   �� 5�      $��Add Car Details��6   $
��Left=�62   $	��Top=�6M   ���	#FF35203B$<��6/CarParts003;component/myfonts/#Champagne & Limousines)�6|   $��18(�6�   $
��Bold"�6�   5�      5�      �� 5�   
   -   5        $��X��5�      $��Right=�6   $	��Top=�69   $��52��6Q   ���	#FFFFF4E0$��24(�6�   $
��Bold"�6�   $��42��6�   ��6\   Z� ��6�   Z� 6�   5�      5�      