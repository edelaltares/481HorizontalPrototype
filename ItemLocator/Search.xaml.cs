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
            getSearch();
        }

        private void getSearch()
        {
            String keywords = searchBox.Text;

            doSearch(keywords);
        }

        private void getText(object sender, RoutedEventArgs e)
        {

        }

        private Product[] doSearch(String keywords)
        {
            List<Product> searchList = new List<Product>();
            List<Product> productList = new List<Product>();

            Product aProduct = new Product("eggs");
            productList.Add(aProduct);

            Product[] productArray = productList.ToArray();

            int size = productArray.Length;

            for(int i=0; i < size; i++)
            {
                if (productList[i].name.Contains(keywords))
                {
                    searchList.Add(productList[i]);
                }
            }

            Product[] searchArray = searchList.ToArray();

            int sizeSearch = searchArray.Length;

            return searchArray;
        }
    }
}
