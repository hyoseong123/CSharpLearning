   M S B A M L   `   `   `  ���� K  GBookStoreWPF_HHS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookStoreWPF_HHSBookStoreWPF_HHS  I)clr-namespace:BookStoreWPF_HHS.ViewModelsBookStoreWPF_HHS.ViewModels  !    BookStoreWPF_HHS.SearchPage   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:BookStoreWPF_HHS     @
ViewModels)clr-namespace:BookStoreWPF_HHS.ViewModels       N� Title$  
SearchPage��.��� .+� � -     �Name$ SearchPageFrame��
�������  � NavigationUIVisibility$ 	Automatic=��� $��Search Book��$��40(�$��	30,10,0,0q�$
��Left=�$	��Top=��� -    ��Name$ 
MainButton��$
��Main��$��50��$	��100��$��650,10,10,350q��� -    ��Name$ 	SearchBox��$��Center=�$��Center=�$
��Left=�$	��200��$��60��$��140,115,0,0q�$��20(� �� TextWrapping$
 Wrap=�$	��Top=����� *SearchInput+ �� UpdateSourceTrigger$ PropertyChanged=��� $��20(�$1��+검색할 단어/번호를 입력하세요.��$��380,127,0,0q�$
��Left=�$	��Top=��� -    ��Name$ NovelCheckBox��$
��Left=�$��15��$��542,265,0,0q�$	��Top=�$��15�� d� 	IsChecked �� *IsNovelChecked+	 � LayoutTransform	 �� 
 �� ScaleX$
 2Q� �� ScaleY$ 2Q��� $��20(�$��Novel��$��527,295,0,0q�$
��Left=�$	��Top=�$��37�� J� RenderTransformOrigin$ 
0.45,0.405&��� -   $ ComicCheckBox��$
��Left=�$��15��$��372,265,0,0q�$	��Top=�$��15�� �� *IsComicChecked+	 �� $
 2Q�$ 2Q��� $��20(�$��Comic��$��357,295,0,0q�$
��Left=�$	��Top=�$��37��$ 
0.45,0.405&��� -   $ AllBookCheckBox��$
��Left=�$��15��$��207,265,0,0q�$	��Top=�$��15�� �� *IsAllBookChecked+	 �� $
 2Q�$ 2Q��� $��20(�$��All Book��$��179,295,0,0q�$
��Left=�$	��Top=�$��37��$ 
0.45,0.405&��� $��20(�$-��'검색할 영역을 선택해주세요.��$��	0,213,0,0q�$��Center=�$	��Top=��� -   $ SearchButton��$��Search��$	��100��$��50��$��625,340,25,10q�