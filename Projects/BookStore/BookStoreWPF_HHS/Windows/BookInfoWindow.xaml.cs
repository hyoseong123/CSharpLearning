using BookStoreWPF_HHS.ViewModels;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace BookStoreWPF_HHS
{
    /// <summary>
    /// BookInfoWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BookInfoWindow : Window
    {
        BookList books;
        BookListViewModel BookListViewModel;

        public BookInfoWindow(BookList bookList, string searchWord)
        {
            InitializeComponent();
            books = bookList;
            BookListViewModel = new(books);

            DataContext = BookListViewModel;

            if (searchWord != null)
            {
                SearchResultLabel.Content = "\"" + searchWord + "\"에 대한 검색결과 :";
            }

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
