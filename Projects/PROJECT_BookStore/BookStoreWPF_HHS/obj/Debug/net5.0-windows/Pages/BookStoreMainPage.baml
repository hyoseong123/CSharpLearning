   M S B A M L   `   `   `  ����K  GBookStoreWPF_HHS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookStoreWPF_HHSBookStoreWPF_HHS  5      I)clr-namespace:BookStoreWPF_HHS.ViewModelsBookStoreWPF_HHS.ViewModels  5      (    "BookStoreWPF_HHS.BookStoreMainPage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:BookStoreWPF_HHS     5      ?	viewmodel)clr-namespace:BookStoreWPF_HHS.ViewModels     5        N� Title$  BookStoreMainPage��5
      .��5      � $	��450��6   $��Bottom=�6    � ColumnDefinitions 5   
   �� 5      .+�5   
    � -   5          �Name$ BookStoreMainPageFrame��5      
�������  � NavigationUIVisibility$ Hidden=�5      �� 5   
   $��
Book Store��5      $��50(�5      $��Center=�5      $	��Top=�5      $��0,30,0,0q�5      �� 5   
   -   5         ��Name$ InsertButton��5      $��Insert Book��5      $��
0,100,10,0q�5      $	��100��5       $��50��5!      $	��Top=�5"   '   $��Right=�6?   $	��150��6[   �� 5$   
   -   5        $ SearchButton��5%      $��Search Book��5&      $��Right=�5'      $��
0,220,10,0q�5(      $	��100��5)      $��50��5*      $	��150��5,      $	��Top=�6   �� 5.   
   -   5        $ DeleteButton��5/      $��Delete Book��50      $��
0,160,10,0q�51      $	��100��52      $��50��53      $	��Top=�54   '   $��Right=�6?   $	��150��6[   �� 56   
   -   5        $ 
ExitButton��57      $
��Exit��58      $��Right=�59      $��	0,0,20,20q�5:      $	��100��5;      $��30��5<      $	��100��5?      $��40��6   $��Bottom=�6%   �� 5A   
   -   5        $ PriceButton��5B      $��Price of All Book��5C      $��Right=�5D      $��
0,280,10,0q�5E      $	��100��5F      $��50��5G      $	��150��5I      $	��Top=�6   �� 5K   
   -   5         ��Name$ BookListBox��5K      $��20,102,180,20q�6F   ��6'   �� *Items+��5L      �� 5M      .R�5N      A�  A� Columns$ 3��6"   $��10,10,10,10q�6.   5O      ��5Q      �� 5R      .R�5S      ��  �� Orientation$ Vertical=�6!   $��Center=�68   $��Center=�6U   .+�5T      �� $��/Resources/BookIcon.png��6    $��Center=�6A   $��Center=�6^   $	��100��6y   $	��100��6�   �� 5U      $��Center=�6W   $��Center=�6t   $��17(�6�   ��6$   �� *number+ �� StringFormat$ 
No. {0:N0}��6�   �� 5V      $��Center=�6:   $��Center=�6W   $��20(�6r   $
��Bold"�6�   ��6$   �� *name+6�   �� 5W      $��Center=�6T   $��Center=�6q   $��15(�6�   ��6$   �� *price+$ 
{0:N0} 원��6�   5X      5Y      5[      5\      5]      