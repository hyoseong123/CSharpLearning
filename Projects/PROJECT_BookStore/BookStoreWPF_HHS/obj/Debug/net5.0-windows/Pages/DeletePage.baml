   M S B A M L   `   `   `  ����K  GBookStoreWPF_HHS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookStoreWPF_HHSBookStoreWPF_HHS  5      I)clr-namespace:BookStoreWPF_HHS.ViewModelsBookStoreWPF_HHS.ViewModels  5      !    BookStoreWPF_HHS.DeletePage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:BookStoreWPF_HHS     5      @
ViewModels)clr-namespace:BookStoreWPF_HHS.ViewModels     5        N� Title$  
DeletePage��5      .��5      � .+�5   
    � -   5          �Name$ DeletePageFrame��5      
�������5      �� 5   
   $��Delete Book��5      $��40(�5      $��	30,10,0,0q�5      $
��Left=�5      $	��Top=�5      �� 5   
   -   5         ��Name$ 
MainButton��5      $
��Main��5      $��50��5      $	��100��5      $��650,10,10,350q�5      �� 5!   
   -   5         ��Name$ 	DeleteBox��5"      $��Center=�5$      $��Center=�5%      $
��Left=�5&      $	��200��5'      $��60��5(      $��313,225,0,0q�5)      $��20(�5*       �� TextWrapping$
 Wrap=�5+      $	��Top=�5,      ��5#      �� *Number+ �� UpdateSourceTrigger$ PropertyChanged=�5,      �� 5.   
   $��20(�5/      $1��+삭제할 책의 번호를 입력하세요.��50      $��265,158,0,0q�51      $
��Left=�52      $	��Top=�53      �� 55   
   -   5        $ DeleteButton��56      $��Delete��57      $	��100��58      $��50��59      $��625,340,25,10q�5:      5;      5=      5>      