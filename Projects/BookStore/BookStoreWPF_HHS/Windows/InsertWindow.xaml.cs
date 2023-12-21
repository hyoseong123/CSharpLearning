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
    /// InsertWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class InsertWindow : Window
    {
        public InsertWindow(InsertBookViewModel insertBookViewModel)
        {
            InitializeComponent();

            DataContext = insertBookViewModel;

            InfoBox.Content = insertBookViewModel.Name + " / " + insertBookViewModel.Number + "번 / " + insertBookViewModel.Price + "원 / " + insertBookViewModel.StringType;
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
