   M S B A M L   `   `   `  ���� J  FDotaAutoChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:DotaAutoChecker.PropertiesDotaAutoChecker.Properties  1clr-namespace:DotaAutoCheckerDotaAutoChecker       DotaAutoChecker.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6p(clr-namespace:DotaAutoChecker.Properties     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:DotaAutoChecker     -     � Title$  DotaChecker��$	��120��$	��350�� � ShowInTaskbar .   � 
ResizeMode$ NoResize=�$��Disabled=� � WindowStyle$
 None=� � 	Resources    BtnStyleTron �� 
TargetType �� Property �� Value  TronBackground  TronGreenBrush �� 
TargetType	 ��Name
 J� SnapsToDevicePixels ��Name �� ContentStringFormat �� ContentStringFormat �� Triggers P� Property P� Value �� 
TargetName3  -System.Windows.Media.Effects.DropShadowEffect   	Direction   RenderingBias   ShadowDepth  TronGreenColor   Color   
BlurRadius   Opacity  BtnTerminateStyleTron  TronRedBrush  TronRedColor  BarStyleTron  TronOrangeBrush��%s  &	        7  7  7  7  7  7  7  7  7  7  7  &	 �    7  7  7  7  7  7  7  7  7  7  7  &	 �    7  �� " ��.���  � ��$ Segoe UI)���  � ��8   ��  � ��8  ��  � ��8  ��  � �� �� " ��.R��� $	 border��#��z��#��z��#��z��
 . ._��� $ contentPresenter��#��z��#��z��# z |�.  #��z��#��z����. #
 z
 #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8   � ���� $ border��8   � ����  �@J�Effect   $ 0Q�$ Quality=�$ 0Q�8  $ 10Q�$ 0.755Q�P�  � �� . . ��� $ border��8   � ���� $ border��8   � ��P�  �@d�	IsChecked$
 TrueY�. ��� $ border��8   � ���� $ border��8 	  � ��P�  � {� .  . ��� $ border�� � �� �	#FFF4F4F4�� $ border�� � �� �	#FFADB2B5�� $ contentPresenter�� � �� �	#FF838383��  �@J�Effect   $ 0Q�$ Quality=�$ 0Q�8 
 $ 5Q�$ 0.755Q���  � y�$ Visible=��� " ��.���  � ��$ Segoe UI)���  � ��8   ��  � ��8  ��  � ��8  ��  � �� �� " ��.R��� $	 border��#��z��#��z��#��z��
 . ._��� $ contentPresenter��#��z��#��z��# z |�.  #��z��#��z����. #
 z
 #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8   � ���� $ border��8   � ����  �@J�Effect   $ 0Q�$ Quality=�$ 0Q�8  $ 12Q�$ 0.755Q�P�  � �� . . ��� $ border��8   � ���� $ border��8   � ��P�  �@d�	IsChecked$
 TrueY�. ��� $ border��8   � ���� $ border��8 	  � ��P�  � {� .  . ��� $ border�� � �� �	#FFF4F4F4�� $ border�� � �� �	#FFADB2B5�� $ contentPresenter�� � �� �	#FF838383��  �@J�Effect   $ 0Q�$ Quality=�$ 0Q�8 
 $ 5Q�$ 0.755Q���  � y�$ Visible=��� " ��.���  � ��$ Segoe UI)���  � �� �	#FF161C1D��  � ��8   .��� -   ���	#FF161C1D.+��� $
��Left=�$��	10,10,0,0q�$
��Wrap=�$��Path to config file:��$	��Top=� 	 TronBlueBrush#��[	 �� $��	10,26,0,0q�$
��Wrap=�$	��Top=�$
��auto��#��[	 ����  
 Settings �� Source# [
  �� Path$ 
ConfigPath��� -    ��Name$ lblCameraDistance��$��	10,47,0,0q�$
��Wrap=�$	��Top=�$
��auto��  TronYellowBrush#��[ �� -   $��
Get Target��$��23��$��70��$
��Left=�$	��Top=�$��	10,68,0,0q�#��[  �� -   $��Fix distance��$��23��$��70��$
��Left=�$	��Top=�$��	85,68,0,0q�#��[   J� RenderTransformOrigin$ 0.486,0.522&��� -   $��	Terminate��$��23��$��70��$
��Left=�$	��Top=�$��
270,68,0,0q�#��[ $ 	0.5,0.478&��� -    ��Name$ StatusBarPanel��$��22��$��0,0,0,0q�$��Bottom=�$��1��#��[ ���� .R��  � ColumnDefinitions �� $��* ��� $
��auto �.@��� -   $ StatusTextBlock���� $��1��.���� -	   $ TimerBox��