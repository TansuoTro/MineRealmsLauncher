   M S B A M L   `   `   `  ����O  KMineRealmsLauncher, Version=4.8.7238.25799, Culture=neutral, PublicKeyToken=null?$clr-namespace:MineRealmsLauncher.ControlsMineRealmsLauncher.Controls  5      ?$clr-namespace:MineRealmsLauncher.ControlsMineRealmsLauncher.Controls  5      H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5      -    'MineRealmsLauncher.Controls.MainPanelControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:MineRealmsLauncher.Controls     5      <userControl$clr-namespace:MineRealmsLauncher.Controls     5      Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      ^ ZMahApps.Metro.IconPacks.FontAwesome, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5	      .��5      �   � ColumnDefinitions  5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ launchButton��5         String.Base.Launch#���   6'   $��
10,0,10,10q�6V   $��50��6j   $��Bottom=�6v   $��14(�5      ���	#332C99F3
�������
�������$��2��6|   �� 5   
   $
��Left=�6J   $��4.161,191.048,0,0q�6f   $
��auto��6�   $	��Top=�6�   
���������6   2  ,MahApps.Metro.IconPacks.FontAwesomeExtension  �  �MahApps.Metro.IconPacks.PackIconExtension`2[[MahApps.Metro.IconPacks.PackIconFontAwesome, MahApps.Metro.IconPacks.FontAwesome, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null],[MahApps.Metro.IconPacks.PackIconFontAwesomeKind, MahApps.Metro.IconPacks.FontAwesome, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ LocationArrowSolid=�6�   �� 5   
   -   5         ��Name$ authTypeCombobox��5      $��30.5,191.047,13,0q�5      $	��Top=�5      ���	#33FFFFFF���	#99FFFFFF �� DisplayMemberPath$ 
Value.Name��5       �� SelectedValuePath$	 Key��5       $  String.MainWindow.ChooseAuthType*  $MahApps.Metro.Controls.TextBoxHelper   	Watermark# �  5      $��2��6i    �� SelectedValue 5      ��  �� ElementName$ userComboBox��	 �� Path$#	 SelectedItem.Value.AuthModule�5   i   �� 5   
   -   5        $��1��5      $��0,224.385,-364.219,0q�6"   $	��Top=�6@   $��Right=�6X   $��35��6t     String.Mainwindow.Auth.Add
 � ToolTip#
 �  6   
�������
�������$��26��5   O   ��6   Z� .��5         $ 	PlusSolid=�6$      Width$ 10X�65      Height$ 10X�6@   5!      �� 5#   
   $
��Left=�6C   $��3.5,120,0,0q�6_   $
��auto��6t   $	��Top=�6�   
���������6     $ RocketSolid=�6�   �� 5$   
   -   5        $ launchVersionCombobox��5$      $��30.5,120,12,0q�5%      $	��Top=�5&      ���	#33FFFFFF���	#99FFFFFF$ ID��5(       ) %String.MainWindow.ChooseLaunchVersion# �  5)      $��2��6n   �� 5,   
   $
��Left=�6A   $
��auto��6\   $	��Top=�6j   $��4.03,155,0,0q�6�   
���������6     $ 	UserSolid=�6�   �� 5-   
   -   5        $ userComboBox��5-       �� 
IsEditable . $��23��5/         ClearTextButton . $��30,155,13,0q�51      $	 Key��52      $ Value.UserName��53      $	��Top=�54      ���	#33FFFFFF���	#99FFFFFF % !String.Mainwindow.InputPlayerName# �  55      $��2��6i   6}   �� 58   
   -   5        $ configButton��58      $��30��59      $��-624.236,0,639.236,10q�6!   $��Bottom=�6@   
�������
���������5:      Z� .��5;        $ CogSolid=�6$   5<      �� 5>   
   -   5        $ downloadButton��5>      $��30��5?      $��-624.236,0,639.236,45q�6!   $��Bottom=�6@   
�������
���������5@      Z� .��5A        $ CloudDownloadAltSolid=�6%   5B      �� 5C   
   $��0,35.329,0,347.671q�6   $,��&/MineRealmsLauncher;component/minecraft.png��6,   $
��Fill=�6\   $��2��6k   5D      5E      