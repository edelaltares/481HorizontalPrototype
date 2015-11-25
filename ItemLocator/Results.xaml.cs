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
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : UserControl
    {
        List<Items> resultList;

        public Results()
        {
            InitializeComponent();
        }

        public Results(List<Items> result, String searchWord)
        {
            InitializeComponent();

            resultList = result;

            if (result.Count() > 10)
            {
                dialogMessage.Content = "Your search returned more than 10 \nresults. You may wish to make your \nsearch more specific to return less.";
                resultsListBox.ItemsSource = result;
                keywordLabel.Content = searchWord;
                resultSearch.Text = searchWord;
            }
            else if (result.Count() != 0)
            {
                resultsListBox.ItemsSource = result;
                keywordLabel.Content = searchWord;
                resultSearch.Text = searchWord;
            }
            else
            {
                dialogMessage.Content = "Your search returned 0 results. The\nproduct you're looking for may not be \nsold here or you may have made a \nspelling mistake.";
            }
        }

        private void clickBack(object sender, RoutedEventArgs e)
        {

        }

        private void itemClick(object sender, RoutedEventArgs e)
        {
            MainWindow main = (MainWindow)Window.GetWindow(this);
            
            Results_Map itemMap = new Results_Map((Items) resultsListBox.SelectedItem);

            main.newPage(itemMap);
        }

        private void newSearch(object sender, RoutedEventArgs e)
        {

        }

        private void searchBox_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void searchBox_TouchEnter(object sender, TouchEventArgs e)
        {

        }

        private void sortNameA(object sender, RoutedEventArgs e)
        {
            resultList = resultList.OrderBy(Items => Items.name).ToList();

            resultsListBox.ItemsSource = resultList;
        }

        private void sortNameZ(object sender, RoutedEventArgs e)
        {
            resultList = resultList.OrderBy(Items => Items.name).Reverse().ToList();

            resultsListBox.ItemsSource = resultList;
        }

        private void sortPriceLow(object sender, RoutedEventArgs e)
        {
            resultList = resultList.OrderBy(Items => Items.price).ToList();

            resultsListBox.ItemsSource = resultList;
        }

        private void sortPriceHigh(object sender, RoutedEventArgs e)
        {
            resultList = resultList.OrderBy(Items => Items.price).Reverse().ToList();

            resultsListBox.ItemsSource = resultList;
        }
    }
}