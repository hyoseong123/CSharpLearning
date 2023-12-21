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
    /// PriceWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PriceWindow : Window
    {
        public int priceResult;

        public PriceWindow(ObservableCollection<Book> bookList)
        {
            InitializeComponent();

            foreach (var item in bookList)
            {
                priceResult += item.price;
            }

            PriceLabel.Content = "현재 전체 재고의 총 가격은 " + priceResult + "원입니다.";
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
