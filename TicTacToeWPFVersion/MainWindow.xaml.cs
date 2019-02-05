using System.Windows;

namespace TicTacToeWPFVersion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void X00Button_Click(object sender, RoutedEventArgs e)
        {
            taken00.Content = "X";
        }
        private void Y00Button_Click(object sender, RoutedEventArgs e)
        {
            taken00.Content = "Y";
        }

        private void X10Button_Click(object sender, RoutedEventArgs e)
        {
            taken10.Content = "X";
        }
        private void Y10Button_Click(object sender, RoutedEventArgs e)
        {
            taken10.Content = "Y";
        }

        private void X20Button_Click(object sender, RoutedEventArgs e)
        {
            taken20.Content = "X";
        }
        private void Y20Button_Click(object sender, RoutedEventArgs e)
        {
            taken20.Content = "Y";
        }

        private void X01Button_Click(object sender, RoutedEventArgs e)
        {
            taken01.Content = "X";
        }
        private void Y01Button_Click(object sender, RoutedEventArgs e)
        {
            taken01.Content = "Y";
        }

        private void X11Button_Click(object sender, RoutedEventArgs e)
        {
            taken11.Content = "X";
        }
        private void Y11Button_Click(object sender, RoutedEventArgs e)
        {
            taken11.Content = "Y";
        }

        private void X21Button_Click(object sender, RoutedEventArgs e)
        {
            taken21.Content = "X";
        }
        private void Y21Button_Click(object sender, RoutedEventArgs e)
        {
            taken21.Content = "Y";
        }

        private void X02Button_Click(object sender, RoutedEventArgs e)
        {
            taken02.Content = "X";
        }
        private void Y02Button_Click(object sender, RoutedEventArgs e)
        {
            taken02.Content = "Y";
        }

        private void X12Button_Click(object sender, RoutedEventArgs e)
        {
            taken12.Content = "X";
        }
        private void Y12Button_Click(object sender, RoutedEventArgs e)
        {
            taken12.Content = "Y";
        }

        private void X22Button_Click(object sender, RoutedEventArgs e)
        {
            taken22.Content = "X";
        }
        private void Y22Button_Click(object sender, RoutedEventArgs e)
        {
            taken22.Content = "Y";
        }

        private void NewGame_Click(object sender, RoutedEventArgs e)
        {
            taken00.Content = "";
            taken10.Content = "";
            taken20.Content = "";
            taken01.Content = "";
            taken11.Content = "";
            taken21.Content = "";
            taken02.Content = "";
            taken12.Content = "";
            taken22.Content = "";
        }
    }
}
