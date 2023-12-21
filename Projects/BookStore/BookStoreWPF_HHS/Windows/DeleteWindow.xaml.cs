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
using System.Windows.Shapes;

namespace BookStoreWPF_HHS
{
    /// <summary>
    /// DeleteWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DeleteWindow : Window
    {
        ObservableCollection<Book> bookList;
        public int _number;

        public DeleteWindow(ObservableCollection<Book> books, int Number)
        {
            InitializeComponent();

            bookList = books;
            _number = Number;

            foreach (var item in bookList)
            {
                if (item.number == Number)
                {
                    InfoBox.Content = item.number + "번 / " + item.name + " / " + item.price + "원";
                    return;
                }
            }
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("취소되었습니다.");

            Window.GetWindow(this).Close();
        }

        private void AcceptButtonClick(object sender, RoutedEventArgs e)
        {
            foreach (var item in bookList)
            {
                if (item.number == _number)
                {
                    bookList.Remove(item);

                    MessageBox.Show("삭제되었습니다.");

                    Window.GetWindow(this).Close();

                    return;
                }
            }
        }
    }
}
