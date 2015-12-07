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
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : UserControl
    {
        public Items[] itemsList;
        public List<Items> salesList = new List<Items>();
        public List<Items> initResults = new List<Items>();


        public Sales(Items[] list)
        {
            InitializeComponent();
            itemsList = list;
        }

        public List<Items> findSales()
        {
            int size = itemsList.Length;

            for(int i=0; i < size; i++)
            {
                if(itemsList[i].isOnSale())
                {
                    salesList.Add(itemsList[i]);
                }
            }

            salesList = salesList.OrderBy(Items => Items.name).ToList();
            initResults= salesList;
            return salesList;
        }

        private void clickBack(object sender, RoutedEventArgs e)
        {

        }

        private void itemClick(object sender, RoutedEventArgs e)
        {

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
            salesList = salesList.OrderBy(Items => Items.name).ToList();

            salesListBox.ItemsSource = salesList;
        }

        private void sortNameZ(object sender, RoutedEventArgs e)
        {
            salesList = salesList.OrderBy(Items => Items.name).Reverse().ToList();

            salesListBox.ItemsSource = salesList;
        }

        private void sortPriceLow(object sender, RoutedEventArgs e)
        {
            salesList = salesList.OrderBy(Items => Items.salePrice).ToList();

            salesListBox.ItemsSource = salesList;
        }

        private void sortPriceHigh(object sender, RoutedEventArgs e)
        {
            salesList = salesList.OrderBy(Items => Items.salePrice).Reverse().ToList();

            salesListBox.ItemsSource = salesList;
        }

        private void sortByLocation(object sender, RoutedEventArgs e)
        {
            salesList = salesList.OrderBy(Items => Items.location).ToList();
            salesListBox.ItemsSource = salesList;
        }
        /* ALL CHECKED */
        private void allChecked(object sender, RoutedEventArgs e)
        {
            if (salesList != null)
            {
                inStockFilter.IsChecked = false;
                dairyFilter.IsChecked = false;
                bakeryFilter.IsChecked = false;
                meatFilter.IsChecked = false;
                produceFilter.IsChecked = false;

                salesList = initResults;

                if (sortAZ.IsSelected) { salesList = salesList.OrderBy(Items => Items.name).ToList(); }
                if (sortZA.IsSelected) { salesList = salesList.OrderBy(Items => Items.name).Reverse().ToList(); }
                if (sortLoHi.IsSelected) { salesList = salesList.OrderBy(Items => Items.price).ToList(); }
                if (sortHiLo.IsSelected) { salesList = salesList.OrderBy(Items => Items.price).Reverse().ToList(); }
                if (sortLoc.IsSelected) { salesList = salesList.OrderBy(Items => Items.location).ToList(); }

                salesListBox.ItemsSource = salesList;
            }
        }

        /* IN STOCK CHECKED */
        private void inStockChecked(object sender, RoutedEventArgs e)
        {
            if (salesList != null)
            {
                if (allFilter.IsChecked.Value)
                {
                    allFilter.IsChecked = false;
                }

                List<Items> newsalesList = new List<Items>();
                int resultsize = salesList.Count;
                for (int i = 0; i < resultsize; i++)
                {
                    newsalesList.Add(salesList.ElementAt(i));
                }

                if ((sender as CheckBox).Content.Equals("In Stock items"))
                {
                    int size = salesList.Count;

                    for (int i = 0; i < size; i++)
                    {
                        if (!salesList.ElementAt(i).inStock)
                        {
                            newsalesList.Remove(salesList.ElementAt(i));
                        }
                    }

                    salesListBox.ItemsSource = newsalesList;

                    salesList = newsalesList;
                }
            }
        }

        /* DAIRY CHECKED */
        private void dairyChecked(object sender, RoutedEventArgs e)
        {
            if (salesList != null)
            {
                List<Items> newsalesList = new List<Items>();
                int resultsize = initResults.Count;
                for (int i = 0; i < resultsize; i++)
                {
                    newsalesList.Add(initResults.ElementAt(i));
                }

                if ((sender as RadioButton).Content.Equals("Dairy items"))
                {
                    int size = initResults.Count;

                    for (int i = 0; i < size; i++)
                    {
                        if (!initResults.ElementAt(i).location.Contains("Dairy"))
                        {
                            newsalesList.Remove(initResults.ElementAt(i));
                        }
                        else if (inStockFilter.IsChecked.Value && !initResults.ElementAt(i).inStock)
                        {
                            newsalesList.Remove(initResults.ElementAt(i));
                        }
                    }

                    salesListBox.ItemsSource = newsalesList;
                    salesList = newsalesList;
                }
            }
        }

        /* BAKERY CHECKED */
        private void bakeryChecked(object sender, RoutedEventArgs e)
        {
            if (salesList != null)
            {
                List<Items> newsalesList = new List<Items>();
                int resultsize = initResults.Count;
                for (int i = 0; i < resultsize; i++)
                {
                    newsalesList.Add(initResults.ElementAt(i));
                }

                if ((sender as RadioButton).Content.Equals("Bakery items"))
                {
                    int size = initResults.Count;

                    for (int i = 0; i < size; i++)
                    {
                        if (!initResults.ElementAt(i).location.Contains("Bakery"))
                        {
                            newsalesList.Remove(initResults.ElementAt(i));
                        }
                        else if (inStockFilter.IsChecked.Value && !initResults.ElementAt(i).inStock)
                        {
                            newsalesList.Remove(initResults.ElementAt(i));
                        }
                    }

                    salesListBox.ItemsSource = newsalesList;
                    salesList = newsalesList;
                }
            }
        }

        /* MEAT CHECKED */
        private void meatChecked(object sender, RoutedEventArgs e)
        {
            if (salesList != null)
            {
                List<Items> newsalesList = new List<Items>();
                int resultsize = initResults.Count;
                for (int i = 0; i < resultsize; i++)
                {
                    newsalesList.Add(initResults.ElementAt(i));
                }

                if ((sender as RadioButton).Content.Equals("Meat items"))
                {
                    int size = initResults.Count;

                    for (int i = 0; i < size; i++)
                    {
                        if (!initResults.ElementAt(i).location.Contains("Meat"))
                        {
                            newsalesList.Remove(initResults.ElementAt(i));
                        }
                        else if (inStockFilter.IsChecked.Value && !initResults.ElementAt(i).inStock)
                        {
                            newsalesList.Remove(initResults.ElementAt(i));
                        }
                    }

                    salesListBox.ItemsSource = newsalesList;
                    salesList = newsalesList;
                }
            }
        }

        /* PRODUCE CHECKED */
        private void produceChecked(object sender, RoutedEventArgs e)
        {
            if (salesList != null)
            {
                List<Items> newsalesList = new List<Items>();
                int resultsize = initResults.Count;
                for (int i = 0; i < resultsize; i++)
                {
                    newsalesList.Add(initResults.ElementAt(i));
                }

                if ((sender as RadioButton).Content.Equals("Produce items"))
                {
                    int size = initResults.Count;

                    for (int i = 0; i < size; i++)
                    {
                        if (!initResults.ElementAt(i).location.Contains("Produce"))
                        {
                            newsalesList.Remove(initResults.ElementAt(i));
                        }
                        else if (inStockFilter.IsChecked.Value && !initResults.ElementAt(i).inStock)
                        {
                            newsalesList.Remove(initResults.ElementAt(i));
                        }
                    }

                    salesListBox.ItemsSource = newsalesList;
                    salesList = newsalesList;
                }
            }
        }

        /* IN STOCK UNCHECKED */
        private void inStockUnchecked(object sender, RoutedEventArgs e)
        {
            List<Items> newsalesList = new List<Items>();
            int resultsize = salesList.Count;
            for (int i = 0; i < resultsize; i++)
            {
                newsalesList.Add(salesList.ElementAt(i));
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

                        newsalesList.Add(initResults.ElementAt(i));
                    }
                }
                salesListBox.ItemsSource = newsalesList;

                salesList = newsalesList;
            }
        }

        private void itemClick(object sender, SelectionChangedEventArgs e)
        {
            MainWindow main = (MainWindow)Window.GetWindow(this);

            Results_Map itemMap = new Results_Map((Items)salesListBox.SelectedItem);

            main.newPage(itemMap);
        }
    }
}
