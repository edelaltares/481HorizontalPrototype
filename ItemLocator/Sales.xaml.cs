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
    }
}
