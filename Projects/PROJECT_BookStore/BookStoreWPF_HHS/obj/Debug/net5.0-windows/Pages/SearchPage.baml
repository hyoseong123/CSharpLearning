   M S B A M L   `   `   `  ����K  GBookStoreWPF_HHS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookStoreWPF_HHSBookStoreWPF_HHS  5      I)clr-namespace:BookStoreWPF_HHS.ViewModelsBookStoreWPF_HHS.ViewModels  5      !    BookStoreWPF_HHS.SearchPage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:BookStoreWPF_HHS     5      @
ViewModels)clr-namespace:BookStoreWPF_HHS.ViewModels     5        N� Title$  
SearchPage��5      .��5      � .+�5   
    � -   5          �Name$ SearchPageFrame��5      
�������  � NavigationUIVisibility$ 	Automatic=�5      �� 5   
   $��Search Book��5      $��40(�5      $��	30,10,0,0q�5      $
��Left=�5      $	��Top=�5      �� 5   
   -   5         ��Name$ 
MainButton��5      $
��Main��5      $��50��5      $	��100��5      $��650,10,10,350q�5       �� 5"   
   -   5         ��Name$ 	SearchBox��5#      $��Center=�5$      $��Center=�5%      $
��Left=�5&      $	��200��5'      $��60��5(      $��140,115,0,0q�5)      $��20(�5*       �� TextWrapping$
 Wrap=�5+      $	��Top=�5,      ��5-      �� *SearchInput+ �� UpdateSourceTrigger$ PropertyChanged=��� 5/   
   $��20(�50      $1��+검색할 단어/번호를 입력하세요.��51      $��380,127,0,0q�52      $
��Left=�53      $	��Top=�54      �� 56   
   -   5         ��Name$ NovelCheckBox��57      $
��Left=�58      $��15��59      $��542,265,0,0q�5:      $	��Top=�5;      $��15��5<       d� 	IsChecked 5=      �� *IsNovelChecked+	 � LayoutTransform	 5>      �� 5?      
 �� ScaleX$
 2Q�5@       �� ScaleY$ 2Q�5A      5C      �� 5E   
   $��20(�5F      $��Novel��5G      $��527,295,0,0q�5H      $
��Left=�5I      $	��Top=�5J      $��37��5K       J� RenderTransformOrigin$ 
0.45,0.405&�5L      �� 5N   
   -   5        $ ComicCheckBox��5O      $
��Left=�5P      $��15��5Q      $��372,265,0,0q�5R      $	��Top=�5S      $��15��5T       5U      �� *IsComicChecked+	 5V      �� 5W      $
 2Q�5X      $ 2Q�5Y      5[      �� 5]   
   $��20(�5^      $��Comic��5_      $��357,295,0,0q�5`      $
��Left=�5a      $	��Top=�5b      $��37��5c      $ 
0.45,0.405&�5d      �� 5f   
   -   5        $ AllBookCheckBox��5g      $
��Left=�5h      $��15��5i      $��207,265,0,0q�5j      $	��Top=�5k      $��15��5l       5m      �� *IsAllBookChecked+	 5n      �� 5o      $
 2Q�5p      $ 2Q�5q      5s      �� 5u   
   $��20(�5v      $��All Book��5w      $��179,295,0,0q�5x      $
��Left=�5y      $	��Top=�5z      $��37��5{      $ 
0.45,0.405&�5|      �� 5~   
   $��20(�5      $-��'검색할 영역을 선택해주세요.��5�      $��	0,213,0,0q�5�      $��Center=�5�      $	��Top=�5�      �� 5�   
   -   5        $ SearchButton��5�      $��Search��5�      $	��100��5�      $��50��5�      $��625,340,25,10q�5�      5�      5�      5�      