   M S B A M L   `   `   `  ����C  ?BreakOut, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BreakOutBreakOut  5   	       BreakOut.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BreakOut     5   	   -   5          � Icon$  icon.png��5       � WindowStartupLocation$ CenterScreen=�5   "    � Title$ BreakOut v1.3��5	   	   $	��700��6   $	��800��6,    � 
ResizeMode$ NoResize=�68   .��5
      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Offset$ 0Q�6    � Color$ Black��6*   � 5      $ 1Q�6   $
 Gray��6*   5      .+�5   
   �� -   5        $��
MainCanvas��5      $	��600��6#   $	��800��60   $��0,0,0,71q�6<   .+�5      �� -   5         ��Name$ player��5      
���   �$��20��65   $	��100��6A   	 �� Bottom$	 0��6M   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   
 �� Top$	 570��6�    �� Left 6_   �� *	XPosition+6�   A� 5      -   5         A�Name$
 ball��5      $��15��6$   $��15��60   
���  �� 6F   �� *X+ 6`   �� *Y+5      �� 5   
    �� TextAlignment$ Justify=�6   $$��ESC:Exit   F3:Start   F4:Pause��6,   $��20(�6R   $��Center=�6`   $��200,630,200,0q�6}   $	��290��6�   �� 5   
   $ Center=�6   $��Score��6+   $��15(�68   $
��Left=�6F   $	��100��6a   $��573,640,0,-10q�6m   �� 5   
   -   5         ��Name$ score��5      $
 Left=�6#   $��15(�68   $
��Left=�6F   $	��100��6a   $��650,640,0,-10q�6m   �� 5   
   $
 Left=�6   $%��Copyright © David Ricardo 2017��6)   $��10(�6O   $
��Left=�6]   $	��212��6x   $��
10,640,0,0q�6�   �� 5   
   $ Center=�6   $��Lifes��6+   $��15(�68   $
��Left=�6F   $��97��6a   $��578,623,0,7q�6l   �� 5   
   -   5        $ lifes��5      $
 Left=�6#   $��15(�68   $
��Left=�6F   $��43��6a   $��650,623,0,22q�6l   5      5      