using BookStoreWPF_HHS.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BookStoreWPF_HHS
{
    /// <summary>
    /// BookStoreMainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BookStoreMainPage : Page
    {
        public BookList books = new();

        BookListViewModel bookListViewModel;

        public string stringType;

        public BookStoreMainPage()
        {
            InitializeComponent();

            bookListViewModel = new(books);

            DataContext = bookListViewModel;
        }

        private void InsertButtonClick(object sender, RoutedEventArgs e)
        {
            InsertPage insertPage = new(books.bookList, this, bookListViewModel);
            this.NavigationService.Navigate(insertPage);
        }

        private void SearchButtonClick(object sender, RoutedEventArgs e)
        {
            SearchPage searchPage = new(books.bookList, this);
            this.NavigationService.Navigate(searchPage);
        }

        private void DeleteButtonClick(object sender, RoutedEventArgs e)
        {
            DeletePage deletePage = new(books.bookList, this, bookListViewModel);
            this.NavigationService.Navigate(deletePage);
        }

        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void PriceButtonClick(object sender, RoutedEventArgs e)
        {
            PriceWindow priceWindow = new(books.bookList);
            priceWindow.ShowDialog();
        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(BookListBox.SelectedItem != null)
            {
                foreach (var item in books.bookList)
                {
                    if (item == BookListBox.SelectedItem)
                    {
                        if (item.type == 1)
                        {
                            stringType = "Comic";
                        }

                        if (item.type == 2)
                        {
                            stringType = "Novel";
                        }

                        MessageBox.Show($"    책명 : {item.name}\n\n    책번호 : {item.number}번\n\n    가격 : {item.price}원\n\n    장르 : {stringType}");
                    }
                }
            }
        }
    }
}
