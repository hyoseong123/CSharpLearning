using BookStoreWPF_HHS.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace BookStoreWPF_HHS
{
    /// <summary>
    /// SearchPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class SearchPage : Page
    {
        public ObservableCollection<Book> books;
        public SearchPageViewModel searchPageViewModel;

        public bool isNumber;
        public int searchNumber;

        public Page _mainPage;

        public SearchPage(ObservableCollection<Book> bookList, Page mainPage)
        {
            InitializeComponent();
            books = bookList;
            searchPageViewModel = new();
            DataContext = searchPageViewModel;
            _mainPage = mainPage;
        }

        private void MainClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(_mainPage);
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Book> filterBookList = new(books);

            BookList itemIndex = new();

            int selectedBookType = searchPageViewModel.SelectedBookType;

            isNumber = int.TryParse(searchPageViewModel.SearchInput, out searchNumber);

            // 필터링 로직
            if (isNumber)
            {
                foreach (var item in filterBookList)
                {
                    if (selectedBookType == 0)
                    {
                        if (item.number == searchNumber)
                        {
                            continue;
                        }
                        itemIndex.Add(item);
                        continue;
                    }

                    if (item.number == searchNumber && item.type == selectedBookType)
                    {
                        continue;
                    }
                    itemIndex.Add(item);
                    continue;
                }
            }
            else
            {
                foreach (var item in filterBookList)
                {
                    bool hasWord = item.name.Contains(searchPageViewModel.SearchInput);

                    if (selectedBookType == 1 && item.type == 2)
                    {
                        if (searchPageViewModel.SearchInput != null && hasWord)
                        {
                            itemIndex.Add(item);
                            continue;
                        }

                        itemIndex.Add(item);
                        continue;
                    }

                    if (selectedBookType == 2 && item.type == 1)
                    {
                        if (searchPageViewModel.SearchInput != null && hasWord)
                        {
                            itemIndex.Add(item);
                            continue;
                        }

                        itemIndex.Add(item);
                        continue;
                    }

                    if (searchPageViewModel.SearchInput != null && !hasWord)
                    {
                        itemIndex.Add(item);
                        continue;
                    }
                }
            }

            for (int i = 0; i < filterBookList.Count(); i++)
            {
                for (int j = 0; j < itemIndex.Count(); j++)
                {
                    if (filterBookList[i] == itemIndex[j])
                    {
                        filterBookList.RemoveAt(i);
                    }
                }
            }

            BookList bookListTemp = new();

            bookListTemp.bookList = filterBookList;

            BookInfoWindow bookInfoWindow = new(bookListTemp, SearchBox.Text);

            bookInfoWindow.ShowDialog();
        }
    }
}
