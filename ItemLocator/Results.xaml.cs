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
        List<Items> initResults;

        public Results()
        {
            InitializeComponent();
        }

        public Results(List<Items> result, String searchWord)
        {
            InitializeComponent();

            initResults = result;

            resultList = result;
            
            if(searchWord.Length == 0)
            {
                dialogMessage.Text = "You did not search for anything.\nPlease try again.";
                keywordLabel.Text = searchWord;
                resultSearch.Text = searchWord;
                resultList = null;
                return;
            }
            
            if(searchWord.Length != 0)
            {
                clearButton.Visibility = Visibility.Visible;
            }

            if (result.Count() > 10)
            {
                dialogMessage.Text = "Your search returned more than 10 results.\n\nYou may wish to make your search more specific to return less.";
                resultsListBox.ItemsSource = result;
                keywordLabel.Text = searchWord;
                resultSearch.Text = searchWord;
                sortLabel.Visibility = Visibility.Visible;
                sortOptions.Visibility = Visibility.Visible;
                locationLabel.Visibility = Visibility.Visible;
            }
            else if (result.Count() != 0)
            {
                resultsListBox.ItemsSource = result;
                keywordLabel.Text = searchWord;
                resultSearch.Text = searchWord;
                sortLabel.Visibility = Visibility.Visible;
                sortOptions.Visibility = Visibility.Visible;
                locationLabel.Visibility = Visibility.Visible;
            }
            else
            {
                dialogMessage.Text = "Your search returned 0 results.\n\nThe product you're looking for may:\n   - Not be sold here, or\n   - You may have made a spelling mistake.";
                keywordLabel.Text = searchWord;
                resultSearch.Text = searchWord;
            }
            
        }
        
        private void clickBack(object sender, RoutedEventArgs e)
        {

        }

        private void itemClick(object sender, RoutedEventArgs e)
        {
            MainWindow main = (MainWindow) Window.GetWindow(this);
            
            Results_Map itemMap = new Results_Map((Items) resultsListBox.SelectedItem);

            main.newPage(itemMap);
        }

        private void newSearch(object sender, RoutedEventArgs e)
        {
            MainWindow main = (MainWindow)Window.GetWindow(this);

            Search aSearch = new Search();

            aSearch.itemsList = main.getItems();

            List<Items> newResultsList = aSearch.doSearch(resultSearch.Text);

            Results newResultPage = new Results(newResultsList, resultSearch.Text);
            
            main.newPage(newResultPage);
        }

        private void searchBox_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void searchBox_TouchEnter(object sender, TouchEventArgs e)
        {

        }

        private void sortNameA(object sender, RoutedEventArgs e)
        {
            if (resultList != null)
            {
                resultList = resultList.OrderBy(Items => Items.name).ToList();

                resultsListBox.ItemsSource = resultList;
            }
        }

        private void sortNameZ(object sender, RoutedEventArgs e)
        {
            if (resultList != null)
            {
                resultList = resultList.OrderBy(Items => Items.name).Reverse().ToList();

                resultsListBox.ItemsSource = resultList;
            }
        }

        private void sortPriceLow(object sender, RoutedEventArgs e)
        {
            if (resultList != null)
            {
                resultList = resultList.OrderBy(Items => Items.price).ToList();

                resultsListBox.ItemsSource = resultList;
            }
        }

        private void sortPriceHigh(object sender, RoutedEventArgs e)
        {
            if (resultList != null)
            {
                resultList = resultList.OrderBy(Items => Items.price).Reverse().ToList();

                resultsListBox.ItemsSource = resultList;
            }
        }

        private void sortByLocation(object sender, RoutedEventArgs e)
        {
            resultList = resultList.OrderBy(Items => Items.location).ToList();
            resultsListBox.ItemsSource = resultList;
        }

        private void showClear(object sender, TextChangedEventArgs e)
        {
            if (!clearButton.IsVisible && resultSearch.Text.Length != 0)
            {
                clearButton.Visibility = Visibility.Visible;
            }
        }

        /* ALL CHECKED */
        private void allChecked(object sender, RoutedEventArgs e)
        {
            if (resultList != null)
            {
                inStockFilter.IsChecked = false;
                dairyFilter.IsChecked = false;
                bakeryFilter.IsChecked = false;
                meatFilter.IsChecked = false;
                produceFilter.IsChecked = false;

                resultList = initResults;

                if (sortAZ.IsSelected) { resultList = resultList.OrderBy(Items => Items.name).ToList(); }
                if (sortZA.IsSelected) { resultList = resultList.OrderBy(Items => Items.name).Reverse().ToList(); }
                if (sortLoHi.IsSelected) { resultList = resultList.OrderBy(Items => Items.price).ToList(); }
                if (sortHiLo.IsSelected) { resultList = resultList.OrderBy(Items => Items.price).Reverse().ToList(); }
                if (sortLoc.IsSelected) { resultList = resultList.OrderBy(Items => Items.location).ToList(); }

                resultsListBox.ItemsSource = resultList;
            }
        }
        
        /* IN STOCK CHECKED */
        private void inStockChecked(object sender, RoutedEventArgs e)
        {
            if (resultList != null)
            {
                if (allFilter.IsChecked.Value)
                {
                    allFilter.IsChecked = false;
                }

                List<Items> newResultList = new List<Items>();
                int resultsize = resultList.Count;
                for (int i = 0; i < resultsize; i++)
                {
                    newResultList.Add(resultList.ElementAt(i));
                }

                if ((sender as CheckBox).Content.Equals("In Stock items"))
                {
                    int size = resultList.Count;

                    for (int i = 0; i < size; i++)
                    {
                        if (!resultList.ElementAt(i).inStock)
                        {
                            newResultList.Remove(resultList.ElementAt(i));
                        }
                    }

                    resultsListBox.ItemsSource = newResultList;

                    resultList = newResultList;
                }
            }
        }

        /* DAIRY CHECKED */
        private void dairyChecked(object sender, RoutedEventArgs e)
        {
            if (resultList != null)
            {
                List<Items> newResultList = new List<Items>();
                int resultsize = initResults.Count;
                for (int i = 0; i < resultsize; i++)
                {
                    newResultList.Add(initResults.ElementAt(i));
                }

                if ((sender as RadioButton).Content.Equals("Dairy items"))
                {
                    int size = initResults.Count;

                    for (int i = 0; i < size; i++)
                    {
                        if (!initResults.ElementAt(i).location.Contains("Dairy"))
                        {
                            newResultList.Remove(initResults.ElementAt(i));
                        }
                        else if(inStockFilter.IsChecked.Value && !initResults.ElementAt(i).inStock)
                        {
                            newResultList.Remove(initResults.ElementAt(i));
                        }
                    }

                    resultsListBox.ItemsSource = newResultList;
                    resultList = newResultList;
                }
            }
        }

        /* BAKERY CHECKED */
        private void bakeryChecked(object sender, RoutedEventArgs e)
        {
            if (resultList != null)
            {
                List<Items> newResultList = new List<Items>();
                int resultsize = initResults.Count;
                for (int i = 0; i < resultsize; i++)
                {
                    newResultList.Add(initResults.ElementAt(i));
                }

                if ((sender as RadioButton).Content.Equals("Bakery items"))
                {
                    int size = initResults.Count;

                    for (int i = 0; i < size; i++)
                    {
                        if (!initResults.ElementAt(i).location.Contains("Bakery"))
                        {
                            newResultList.Remove(initResults.ElementAt(i));
                        }
                        else if (inStockFilter.IsChecked.Value && !initResults.ElementAt(i).inStock)
                        {
                            newResultList.Remove(initResults.ElementAt(i));
                        }
                    }

                    resultsListBox.ItemsSource = newResultList;
                    resultList = newResultList;
                }
            }
        }

        /* MEAT CHECKED */
        private void meatChecked(object sender, RoutedEventArgs e)
        {
            if (resultList != null)
            {
                List<Items> newResultList = new List<Items>();
                int resultsize = initResults.Count;
                for (int i = 0; i < resultsize; i++)
                {
                    newResultList.Add(initResults.ElementAt(i));
                }

                if ((sender as RadioButton).Content.Equals("Meat items"))
                {
                    int size = initResults.Count;

                    for (int i = 0; i < size; i++)
                    {
                        if (!initResults.ElementAt(i).location.Contains("Meat"))
                        {
                            newResultList.Remove(initResults.ElementAt(i));
                        }
                        else if (inStockFilter.IsChecked.Value && !initResults.ElementAt(i).inStock)
                        {
                            newResultList.Remove(initResults.ElementAt(i));
                        }
                    }

                    resultsListBox.ItemsSource = newResultList;
                    resultList = newResultList;
                }
            }
        }

        /* PRODUCE CHECKED */
        private void produceChecked(object sender, RoutedEventArgs e)
        {
            if (resultList != null)
            {
                List<Items> newResultList = new List<Items>();
                int resultsize = initResults.Count;
                for (int i = 0; i < resultsize; i++)
                {
                    newResultList.Add(initResults.ElementAt(i));
                }

                if ((sender as RadioButton).Content.Equals("Produce items"))
                {
                    int size = initResults.Count;

                    for (int i = 0; i < size; i++)
                    {
                        if (!initResults.ElementAt(i).location.Contains("Produce"))
                        {
                            newResultList.Remove(initResults.ElementAt(i));
                        }
                        else if (inStockFilter.IsChecked.Value && !initResults.ElementAt(i).inStock)
                        {
                            newResultList.Remove(initResults.ElementAt(i));
                        }
                    }

                    resultsListBox.ItemsSource = newResultList;
                    resultList = newResultList;
                }
            }
        }

        /* IN STOCK UNCHECKED */
        private void inStockUnchecked(object sender, RoutedEventArgs e)
        {
            List<Items> newResultList = new List<Items>();
            int resultsize = resultList.Count;
            for (int i = 0; i < resultsize; i++)
            {
                newResultList.Add(resultList.ElementAt(i));
            }

            if ((sender as CheckBox).Content.Equals("In Stock items"))
            {
                int size = initResults.Count;

                for (int i = 0; i < size; i++)
                {
                    if (!initResults.ElementAt(i).inStock)
                    {
                        if (bakeryFilter.IsChecked.Value && !initResults.ElementAt(i).location.Equals("Bakery")) { continue; }
                        if (dairyFilter.IsChecked.Value && !initResults.ElementAt(i).location.Equals("Dairy")) { continue; }
                        if (meatFilter.IsChecked.Value && !initResults.ElementAt(i).location.Equals("Meat")) { continue; }
                        if (produceFilter.IsChecked.Value && !initResults.ElementAt(i).location.Equals("Produce")) { continue; }
                        if ((bakeryFilter.IsChecked.Value || dairyFilter.IsChecked.Value || meatFilter.IsChecked.Value || produceFilter.IsChecked.Value) && initResults.ElementAt(i).location.Contains("Aisle")) { continue; }

                        newResultList.Add(initResults.ElementAt(i));
                    }
                }
                resultsListBox.ItemsSource = newResultList;

                resultList = newResultList;
            }
        }
        
        private void clearSearch(object sender, RoutedEventArgs e)
        {
            resultSearch.Text = "";
            clearButton.Visibility = Visibility.Collapsed;
        }

        private void itemClick(object sender, SelectionChangedEventArgs e)
        {
            MainWindow main = (MainWindow)Window.GetWindow(this);

            Results_Map itemMap = new Results_Map((Items)resultsListBox.SelectedItem);

            main.newPage(itemMap);
        }

        private void newSearchKey(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            { 
                newSearch(sender, e);
            }
        }

        private void scrollMouse(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }
}