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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : UserControl
    {
        public Items[] itemsList;
        public Search()
        {
            InitializeComponent();
        }
        
        private void searchBox_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void searchBox_TouchEnter(object sender, TouchEventArgs e)
        {

        }

        private void newSearch(object sender, RoutedEventArgs e)
        {
            String keywords = searchBox.Text;

            List<Items> result = doSearch(keywords);

            Results newResult = new Results(result, keywords);

            MainWindow main = (MainWindow) Window.GetWindow(this);

            main.newPage(newResult);
        }

        private void getText(object sender, RoutedEventArgs e)
        {

        }

        private List<Items> doSearch(String keywords)
        {
            List<Items> searchList = new List<Items>();

            int size = itemsList.Length;

            for(int i=0; i < size; i++)
            {
                if (itemsList[i].name.ToLower().Contains(keywords.ToLower()))
                {
                    searchList.Add(itemsList[i]);
                }
            }

            return searchList;
        }

        private void showClear(object sender, TextChangedEventArgs e)
        {
            if (!clearButton.IsVisible && searchBox.Text.Length != 0)
            {
                clearButton.Visibility = Visibility.Visible;
            }
        }

        private void clearSearch(object sender, RoutedEventArgs e)
        {
            searchBox.Text = "";
            clearButton.Visibility = Visibility.Collapsed;
        }
    }
}
