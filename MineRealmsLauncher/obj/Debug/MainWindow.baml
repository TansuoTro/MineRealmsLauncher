   M S B A M L   `   `   `  ����O  KMineRealmsLauncher, Version=4.8.7238.25799, Culture=neutral, PublicKeyToken=null-clr-namespace:MineRealmsLauncherMineRealmsLauncher  5   	   ?$clr-namespace:MineRealmsLauncher.ControlsMineRealmsLauncher.Controls  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       MineRealmsLauncher.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:MineRealmsLauncher     5   	   <userControl$clr-namespace:MineRealmsLauncher.Controls     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   ^ ZMahApps.Metro.IconPacks.FontAwesome, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5	   	   -   5        (  "MahApps.Metro.Controls.MetroWindow   Name$  
mainWindow��5         AccentColorBrush#���   5   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ MineRealms Launcher��5   	   $��474.568��6    $��862.359��61   $	��445��6A   $	��720��6Q      ShowMaxRestoreButton .     ShowMinButton . ��5      �� 5   
    �� ImageSource$ Resource/bg.png��6    j� TileMode$ FlipXY=�63    j� 
AlignmentX$ Right=�6E    j� Stretch$ UniformToFill=�6X   .��5      � 	 � ColumnDefinitions	 5   
   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��11* �6   .+�5   
   r� -   5        
 r�Name$
 mediaElement��5      $y�Hidden=�6-    r� LoadedBehavior$ Manual=�6A   $��2��6~   � 5   
   -   5         �Name$ userGrid��5      $��2��6!   $��82.79,0,0,0q�61    � RowDefinitions 5      �� 5      $	��80* �6    �� 5      $	��71* �6    .+�5      �� $��2��6    J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5          Radius$ 20Q�6!   ��5"      !� 5#      $ UniformToFill=�6"   $ Right=�6:    !� Visual 5$      �� 5%      ��6(   �� *ActualWidth+ �� ElementName$ 
mainWindow����5&   (   �� *ActualHeight+$ 
mainWindow����5'   (   �� *
Background+$ 
mainWindow��5*      5,      �� 5-      
������� J� Opacity$	 0.2Q�6%   $��2��63   -   'MineRealmsLauncher.Controls.MainPanelControl  5/      -   5          Name$ 	mainPanel��5/   +   $��2��6>   50      �� 51   
   -   5         ��Name$ volumeButton��51       / +MahApps.Metro.Styles.MetroCircleButtonStyle#���  6'   $��30��52      $��30��6   $��	0,10,10,0q�6(   $	��Top=�6;   $��Right=�6S   
�������
�������$��2��53   S   $y�Hidden=�6g   .��54      2  ,MahApps.Metro.IconPacks.FontAwesomeExtension  -   5        volumeButtonIcon���  �MahApps.Metro.IconPacks.PackIconExtension`2[[MahApps.Metro.IconPacks.PackIconFontAwesome, MahApps.Metro.IconPacks.FontAwesome, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null],[MahApps.Metro.IconPacks.PackIconFontAwesomeKind, MahApps.Metro.IconPacks.FontAwesome, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ VolumeUpSolid=�54   >   55      .   (MineRealmsLauncher.Controls.ServerInfoControl  57   
   -   5          Name$ serverInfoControl��57   (   $	��125��6C   $��10,10,118,0q�6P   $	��Top=�6e   $��2��6}   � 59   
   -   5        $ loadingGrid��59      $y�Hidden=�6$   $��3��68   .+�5:      �� ��6   �� *
Background+$ 
mainWindow�� 5;        5<      $ 20Q�6!   5>      �� 5?      $��Center=�6   $��Center=�66   .+�5@      )  #MahApps.Metro.Controls.ProgressRing  -	   5          Name$ loadingRing��5@   (   $��70��6=   $��70��6H      IsActive .  6T   �� 5A        String.Mainwindow.Launching#���  6    �� TextAlignment$ Center=�6Q   
�������6h   �� 5B      -
   5        $ cancelLaunchButton��5B      $��取消启动��65   $��30��6D   $��70��6P   $��0,10,0,0q�6[   $	 0.6Q�6m   5C      �� 5D      -   5         ��Name$ launchInfoBlock��5D      $��20��61   $ Right=�6=   
�������$��Bottom=�6e   $
��10,0q�6�   5E      �� 5F   
   $E��?请使用Minerealms验证登录
       无账号请点击注册��6   $��2��6@   $
��Left=�6P   $��82.79,243.965,-39.624,0q�6k   $	��Top=�6�   $��64.96��6�   $��259.994��6�   $��17(�6�   �� 5G   
   $$��129.031,220.671,34.872,189.603q�6   $��20(�6<   $��2��6J   �� 6[   -   5        $-��'https://minerealms.cn:666/auth/register?�5G   e   .�5H      �� $�点我注册账号��6   6$   60   5I      5J      