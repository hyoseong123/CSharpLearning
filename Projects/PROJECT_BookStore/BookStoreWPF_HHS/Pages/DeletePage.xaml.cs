using BookStoreWPF_HHS.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// DeletePage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DeletePage : Page
    {
        public ObservableCollection<Book> books;
        
        BookListViewModel bookListViewModel;

        private Page _mainPage;

        public DeletePage(ObservableCollection<Book> bookList, Page mainPage, BookListViewModel _bookListViewModel)
        {
            InitializeComponent();

            books = bookList;

            bookListViewModel = _bookListViewModel;

            _mainPage = mainPage;
        }

        private void MainClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(_mainPage);

            bookListViewModel.Items = new ObservableCollection<Book>(books.OrderBy(x => x.number).ThenBy(x => x));
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            int deleteNumber;

            if(!int.TryParse(DeleteBox.Text, out deleteNumber))
            {
                return;
            }

            foreach (var item in books)
            {
                if (item.number == deleteNumber)
                {
                    DeleteWindow deleteWindow = new(books, deleteNumber);
                    deleteWindow.ShowDialog();
                    return;
                }
            }

            MessageBox.Show("일치하는 책이 없습니다.");
            return;
        }
    }
}
