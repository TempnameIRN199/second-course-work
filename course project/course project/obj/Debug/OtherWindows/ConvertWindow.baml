   M S B A M L   `   `   `  ����I  Ecourse project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:course_project.OtherWindowscourse_project.OtherWindows  5   	   /    )course_project.OtherWindows.ConvertWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:course_project.OtherWindows     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ ConvertWindow��5	   	   $	��450��6   $	��800��6,   .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ AttendanceListView��5      ��6/   �� *
Attendance+ �� View 5      �� 5      .P�5      �� $��Id��6%    �� Width$ 1��61    �� DisplayMemberBinding 6;   �� *Id+�� 5      $��Student Name��6%   $
 Auto��6;    6H   �� *StudentName+�� 5      $��Subject Name��6%   $
 Auto��6;    6H   �� *SubjectName+�� 5      $
��Skip��6%   $
 Auto��63    6@   �� *Skip11+5      5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $
��Left=�6;   .+�5      �� -   5        $��
SaveButton��5      $	��100��6'   $��Convert��63   $��5q�6^   �� 5      -   5        $��CloseButton��5      $	��100��6(   $��Close��64   $��5q�6^   5      5      5       