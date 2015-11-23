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
        private Search search;
        private Map map = new Map();
        private Sales sales = new Sales();

        public MainWindow()
        {
            InitializeComponent();
            search = new Search(this);
            stack1.Children.Add(search);
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void newPage(UserControl nextPage)
        {
            stack1.Children.Clear();
            stack1.Children.Add(nextPage);
        }

        private void ShowMenu(object sender, RoutedEventArgs e)
        {
            if (!menu.IsVisible)
            {
                menu.Visibility = Visibility.Visible;
            }
            else
            {
                menu.Visibility = Visibility.Collapsed;
            }
        }
        
        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            if(stack1.Children.Contains(search))
            {
                return;
            }
            else if(stack1.Children.Contains(map) || stack1.Children.Contains(sales)) {
                stack1.Children.Clear();
                stack1.Children.Add(search);
            }
            else
            {
                stack1.Children.Add(search);
            }
        }

        private void MapButtonClick(object sender, RoutedEventArgs e)
        {
            if (stack1.Children.Contains(map))
            {
                return;
            }
            else if (stack1.Children.Contains(search) || stack1.Children.Contains(sales))
            {
                stack1.Children.Clear();
                stack1.Children.Add(map);
            }
            else
            {
                stack1.Children.Add(map);
            }
        }

        private void SalesButtonClick(object sender, RoutedEventArgs e)
        {
            if (stack1.Children.Contains(sales))
            {
                return;
            }
            else if (stack1.Children.Contains(search) || stack1.Children.Contains(map))
            {
                stack1.Children.Clear();
                stack1.Children.Add(sales);
            }
            else
            {
                stack1.Children.Add(sales);
            }
        }
    }
}
