   M S B A M L   `   `   `  ���� C  ?BreakOut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BreakOutBreakOut      BreakOut.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:BreakOut     -     � Icon$  icon.png�� � WindowStartupLocation$ CenterScreen=� � Title$ BreakOut v1.3��$	��700��$	��800�� � 
ResizeMode$ NoResize=�.��� ����  �� 
StartPoint$	 0,0&� �� EndPoint$	 0,1&�.���  � Offset$ 0Q� � Color$ Black��� $ 1Q�$
 Gray��.+��� -   $��
MainCanvas��$	��600��$	��800��$��0,0,0,71q�.+��� -    ��Name$ player��
���   �$��20��$	��100��	 �� Bottom$	 0��
 J� RenderTransformOrigin$
 0.5,0.5&�
 �� Top$	 570�� �� Left �� *	XPosition+A� -    A�Name$
 ball��$��15��$��15��
���  �� �� *X+ �� *Y+��  �� TextAlignment$ Justify=�$$��ESC:Exit   F3:Start   F4:Pause��$��20(�$��Center=�$��200,630,200,0q�$	��290���� $ Center=�$��Score��$��15(�$
��Left=�$	��100��$��573,640,0,-10q��� -    ��Name$ score��$
 Left=�$��15(�$
��Left=�$	��100��$��650,640,0,-10q��� $
 Left=�$%��Copyright © David Ricardo 2017��$��10(�$
��Left=�$	��212��$��
10,640,0,0q��� $ Center=�$��Lifes��$��15(�$
��Left=�$��97��$��578,623,0,7q��� -   $ lifes��$
 Left=�$��15(�$
��Left=�$��43��$��650,623,0,22q�