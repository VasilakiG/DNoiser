   M S B A M L   `   `   `  ����  DNoiser    DNoiser.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$  OptiX DNoiser - NVidia��5   	   $	��362��6(   $��533.667��65    � 
ResizeMode$ NoResize=�5   	   ���	#FF1B1B1B � Icon$ DNoiser.ico��6O   .��5      �  � RowDefinitions 5   
   �� 5      $	��34* �6   �� 5	      $
��287* �6   .+�5   
   �� -   5         ��Name$ library_label��5         HoverEnabled#��[  6'   $��Library��6M   $
��Left=�6_   $��10,7,0,0q�6z   
�������$��58��5   #   $��Bottom=�6.   $��Roboto)�5      $
��Bold"�6$    J� RenderTransformOrigin$ 0.475,0.778&�66   $��Center=�6~   �� 5   
   -   5        $ denoise_label��5      #��[  6'   $��Denoise��6M   $
��Left=�6_   $��73,7,0,0q�6z   
�������$��58��5   #   $��Bottom=�6.   $��Roboto)�5      $��Regular"�6$   $ 0.475,0.778&�69   $��Center=�6�    � 5   
   -   5          �Name$ 
main_frame��5      $
��Left=�6$   $	��255��6?   $��1��6L   $	��Top=�6Y   $	��519��6q     � NavigationUIVisibility$ Hidden=�6}   �� 5   
   -   5        $ creators_label��5      $6��0Powered by NVidia - Mitko Nikov - Declan Russell��6(   $
��Left=�6c   $��242,260,0,0q�6~   $��1��6�   $	��Top=�6�   
�������$��Roboto Light)�6�   �� 5   
   -   5        $ creators_label_Copy��5      $��For personal use only��6-   $
��Left=�6M   $��
17,260,0,0q�6h   $��1��6|   $	��Top=�6�   
�������$��Roboto Light)�6�   5      5      