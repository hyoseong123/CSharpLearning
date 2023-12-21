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
    /// InsertPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InsertPage : Page
    {
        public InsertBookViewModel insertBookViewModel = new();

        public ObservableCollection<Book> books;

        BookListViewModel bookListViewModel;

        private Page _mainPage;

        public bool isCheckBoxUnChecked;

        public InsertPage(ObservableCollection<Book> bookList, Page mainPage, BookListViewModel _bookListViewModel)
        {
            InitializeComponent();
            books = bookList;
            _mainPage = mainPage;

            bookListViewModel = _bookListViewModel;

            DataContext = insertBookViewModel;
        }

        private void MainClick(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(_mainPage);
        }

        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            int numberText;
            int priceText;

            bool isNumberNumber = int.TryParse(NumberTextBox.Text, out numberText);
            bool isNumberPrice = int.TryParse(PriceTextBox.Text, out priceText);
            
            if (ComicCheckBox.IsChecked == false && NovelCheckBox.IsChecked == false)
            {
                isCheckBoxUnChecked = true;
            }
            else
            {
                isCheckBoxUnChecked = false;
            }

            if (NameTextBox.Text == "" || NumberTextBox.Text == "0" || PriceTextBox.Text == "0" || isCheckBoxUnChecked || !isNumberNumber || !isNumberPrice)
            {
                MessageBox.Show("잘못된 입력입니다.");
                return;
            }

            foreach (var item in books)
            {
                if (item.number == numberText)
                {
                    MessageBox.Show("중복된 번호입니다.");
                    return;
                }
            }

            InsertWindow insertWindow = new(insertBookViewModel);

            Book newBook = new Book { name = NameTextBox.Text, number = numberText, price = priceText, type = insertBookViewModel.Type};

            books.Add(newBook);

            bookListViewModel.Items = new ObservableCollection<Book>(books.OrderBy(x => x.number).ThenBy(x => x));

            insertWindow.ShowDialog();
        }
    }   
}
