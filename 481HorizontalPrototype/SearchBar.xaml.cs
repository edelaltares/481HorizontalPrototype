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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for SearchBar.xaml
    /// </summary>
    public partial class SearchBar : Page
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            if (menuRectangle.Width == 0)
            {
                menuRectangle.Width = 151;
                homeButton.Width = 150;
                mapButton.Width = 150;
                salesButton.Width = 150;
            }
            else
            {
                menuRectangle.Width = 0;
                homeButton.Width = 0;
                mapButton.Width = 0;
                salesButton.Width = 0;
            }
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            menuRectangle.Width = 0;
            homeButton.Width = 0;
            mapButton.Width = 0;
            salesButton.Width = 0;
        }

        private void mapButton_Click(object sender, RoutedEventArgs e)
        {
            menuRectangle.Width = 0;
            homeButton.Width = 0;
            mapButton.Width = 0;
            salesButton.Width = 0;
        }

        private void salesButton_Click(object sender, RoutedEventArgs e)
        {
            menuRectangle.Width = 0;
            homeButton.Width = 0;
            mapButton.Width = 0;
            salesButton.Width = 0;
        }

        private void magButton_Click(object sender, RoutedEventArgs e)
        {
            gotoLabel.Content = "Go to results";
        }

        private void searchBox_TouchEnter(object sender, TouchEventArgs e)
        {
            menuRectangle.Width = 0;
            homeButton.Width = 0;
            mapButton.Width = 0;
            salesButton.Width = 0;
        }

        private void searchBox_MouseEnter(object sender, MouseEventArgs e)
        {
            menuRectangle.Width = 0;
            homeButton.Width = 0;
            mapButton.Width = 0;
            salesButton.Width = 0;
        }
    }

}
