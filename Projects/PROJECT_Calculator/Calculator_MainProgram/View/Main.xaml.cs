using NewCalculator_HHS.Model;
using NewCalculator_HHS.ViewModel;
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

namespace NewCalculator_HHS.View
{
    /// <summary>
    /// Main.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Main : Window
    {
        MainViewModel mainViewModel;

        public Main()
        {
            InitializeComponent();

            mainViewModel = MainViewModel.GetInstance();

            DataContext = mainViewModel;

            clearButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            zeroButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.InsertNumber(0);
        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.InsertNumber(1);
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.InsertNumber(2);
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.InsertNumber(3);
        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.InsertNumber(4);
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.InsertNumber(5);
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.InsertNumber(6);
        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.InsertNumber(7);
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.InsertNumber(8);
        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.InsertNumber(9);
        }

        private void plusButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AddList("+");
        }

        private void minusButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AddList("-");
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AddList("*");
        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AddList("/");
        }

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.Change();
        }

        private void dotButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.dot();
        }

        private void leftBracketButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AddList("(");
        }

        private void rightBracketButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AddList(")");
        }

        private void backspaceButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.Backspace();
        }

        private void percentButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AddList("%");
        }

        private void squareButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AddList("^");
        }

        private void rootButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AddList("√");
        }

        private void factorialButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.AddList("!");
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.Clear();
        }

        private void equalButton_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.Equal();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.D1))
            {
                factorialButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.D9))
            {
                leftBracketButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.D0))
            {
                rightBracketButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.D8))
            {
                multiplyButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.D6))
            {
                squareButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.D5))
            {
                percentButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (Keyboard.IsKeyDown(Key.LeftShift) && Keyboard.IsKeyDown(Key.D2))
            {
                rootButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.C)
            {
                clearButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.Back)
            {
                backspaceButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.Enter)
            {
                equalButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.R)
            {
                changeButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
            else if (e.Key == Key.D1)
            {
                oneButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.D2)
            {
                twoButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.D3)
            {
                threeButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.D4)
            {
                fourButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.D5)
            {
                fiveButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.D6)
            {
                sixButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.D7)
            {
                sevenButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.D8)
            {
                eightButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.D9)
            {
                nineButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.D0)
            {
                zeroButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.OemPlus)
            {
                plusButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.OemMinus)
            {
                minusButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.Oem2)
            {
                divideButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
            else if (e.Key == Key.OemPeriod)
            {
                dotButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
        }
    }
}
