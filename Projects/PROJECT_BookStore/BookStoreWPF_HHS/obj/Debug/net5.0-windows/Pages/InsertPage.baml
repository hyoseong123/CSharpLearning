   M S B A M L   `   `   `  ����K  GBookStoreWPF_HHS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookStoreWPF_HHSBookStoreWPF_HHS  5      I)clr-namespace:BookStoreWPF_HHS.ViewModelsBookStoreWPF_HHS.ViewModels  5      !    BookStoreWPF_HHS.InsertPage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:BookStoreWPF_HHS     5      @
ViewModels)clr-namespace:BookStoreWPF_HHS.ViewModels     5        N� Title$  
InsertPage��5
      .��5      � .+�5   
    � -   5          �Name$ InsertPageFrame��5      
�������  � NavigationUIVisibility$ 	Automatic=�5      �� 5   
   $��Insert Book��5      $��40(�5      $��	30,10,0,0q�5      $
��Left=�5      $	��Top=�5      �� 5   
   -   5         ��Name$ 
MainButton��5      $
��Main��5      $��50��5      $	��100��5      $��650,10,10,350q�5      �� 5   
   -   5         ��Name$ NameTextBox��5       $��Center=�5"      $��Center=�5#      $
��Left=�5$      $	��200��5%      $��60��5&      $��	80,93,0,0q�5'      $��20(�5(       �� TextWrapping$
 Wrap=�5)      $	��Top=�5*      ��5!      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=�5*      �� 5,   
   $��20(�5-      $*��$책의 제목을 입력해주세요.��5.      $��320,105,0,0q�5/      $
��Left=�50      $	��Top=�51      �� 53   
   -   5        $ NumberTextBox��54      $��Center=�56      $��Center=�57      $
��Left=�58      $	��200��59      $��60��5:      $��
80,161,0,0q�5;      $��20(�5<      $
 Wrap=�5=      $	��Top=�5>      ��55      �� *Number+$ PropertyChanged=�5>      �� 5@   
   $��20(�5A      $*��$책의 번호를 입력해주세요.��5B      $��320,173,0,0q�5C      $
��Left=�5D      $	��Top=�5E      �� 5G   
   -   5        $ PriceTextBox��5H      $��Center=�5J      $��Center=�5K      $
��Left=�5L      $	��200��5M      $��60��5N      $��
80,233,0,0q�5O      $��20(�5P      $
 Wrap=�5Q      $	��Top=�5R      ��5I      �� *Price+$ PropertyChanged=�5R      �� 5T   
   $��20(�5U      $*��$책의 가격을 입력해주세요.��5V      $��320,245,0,0q�5W      $
��Left=�5X      $	��Top=�5Y      �� 5[   
   -   5         ��Name$ ComicCheckBox��5\      $
��Left=�5]      $��15��5^      $��105,308,0,0q�5_      $	��Top=�5`      $��15��5a       d� 	IsChecked 5b      �� *ComicTypeChecked+	 � LayoutTransform	 5c      �� 5d      
 �� ScaleX$
 2Q�6!    �� ScaleY$ 2Q�6,   5f      �� 5h   
   $��20(�5i      $��Comic��5j      $��
90,338,0,0q�5k      $
��Left=�5l      $	��Top=�5m      $��37��5n       J� RenderTransformOrigin$ 
0.45,0.405&�5o      �� 5q   
   -   5        $ NovelCheckBox��5r      $
��Left=�5s      $��15��5t      $��218,308,0,0q�5u      $	��Top=�5v      $��15��5w       5x      �� *NovelTypeChecked+	 5y      �� 5z      $
 2Q�6!   $ 2Q�6,   5|      �� 5~   
   $��20(�6   $��Novel��6   $��203,338,0,0q�6.   $
��Left=�6D   $	��Top=�6_   $��37��6w   $ 
0.45,0.405&�6�   �� 5   
   $��20(�6   $*��$책의 장르를 선택해주세요.��6   $��320,320,0,0q�67   $
��Left=�6M   $	��Top=�6h   �� 5�   
   -   5        $	��ADD��5�      $	��100��6   $��50��6.   $��600,300,50,50q�6=   6T   5�      5�      