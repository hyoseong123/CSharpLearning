   M S B A M L   `   `   `  ���� K  GBookStoreWPF_HHS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:BookStoreWPF_HHSBookStoreWPF_HHS  I)clr-namespace:BookStoreWPF_HHS.ViewModelsBookStoreWPF_HHS.ViewModels  !    BookStoreWPF_HHS.InsertPage   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     0localclr-namespace:BookStoreWPF_HHS     @
ViewModels)clr-namespace:BookStoreWPF_HHS.ViewModels       N� Title$  
InsertPage��.��� .+� � -     �Name$ InsertPageFrame��
�������  � NavigationUIVisibility$ 	Automatic=��� $��Insert Book��$��40(�$��	30,10,0,0q�$
��Left=�$	��Top=��� -    ��Name$ 
MainButton��$
��Main��$��50��$	��100��$��650,10,10,350q��� -    ��Name$ NameTextBox��$��Center=�$��Center=�$
��Left=�$	��200��$��60��$��	80,93,0,0q�$��20(� �� TextWrapping$
 Wrap=�$	��Top=����� *Name+ �� UpdateSourceTrigger$ PropertyChanged=��� $��20(�$*��$책의 제목을 입력해주세요.��$��320,105,0,0q�$
��Left=�$	��Top=��� -   $ NumberTextBox��$��Center=�$��Center=�$
��Left=�$	��200��$��60��$��
80,161,0,0q�$��20(�$
 Wrap=�$	��Top=����� *Number+$ PropertyChanged=��� $��20(�$*��$책의 번호를 입력해주세요.��$��320,173,0,0q�$
��Left=�$	��Top=��� -   $ PriceTextBox��$��Center=�$��Center=�$
��Left=�$	��200��$��60��$��
80,233,0,0q�$��20(�$
 Wrap=�$	��Top=����� *Price+$ PropertyChanged=��� $��20(�$*��$책의 가격을 입력해주세요.��$��320,245,0,0q�$
��Left=�$	��Top=��� -    ��Name$ ComicCheckBox��$
��Left=�$��15��$��105,308,0,0q�$	��Top=�$��15�� d� 	IsChecked �� *ComicTypeChecked+	 � LayoutTransform	 �� 
 �� ScaleX$
 2Q� �� ScaleY$ 2Q��� $��20(�$��Comic��$��
90,338,0,0q�$
��Left=�$	��Top=�$��37�� J� RenderTransformOrigin$ 
0.45,0.405&��� -   $ NovelCheckBox��$
��Left=�$��15��$��218,308,0,0q�$	��Top=�$��15�� �� *NovelTypeChecked+	 �� $
 2Q�$ 2Q��� $��20(�$��Novel��$��203,338,0,0q�$
��Left=�$	��Top=�$��37��$ 
0.45,0.405&��� $��20(�$*��$책의 장르를 선택해주세요.��$��320,320,0,0q�$
��Left=�$	��Top=��� -   $	��ADD��$	��100��$��50��$��600,300,50,50q�