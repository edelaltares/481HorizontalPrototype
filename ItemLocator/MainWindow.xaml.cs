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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ItemLocator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Search search = new Search();

        public MainWindow()
        {
            InitializeComponent();
            stack1.Children.Add(search);
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }


        private void ShowMenu(object sender, RoutedEventArgs e)
        {
            if (!menu.IsVisible)
            {
                menu.Visibility = Visibility.Visible;
            }
            else
            {
                menu.Visibility = Visibility.Hidden;
            }
        }
        
        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void MapButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void SalesButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
