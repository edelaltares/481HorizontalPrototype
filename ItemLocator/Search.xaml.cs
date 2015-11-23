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
            String keywords = searchBox.Text;

            List<Product> result = doSearch(keywords);

            Results newResult = new Results(result, keywords);

            MainWindow main = (MainWindow) Window.GetWindow(this);

            main.newPage(newResult);
        }

        private void getText(object sender, RoutedEventArgs e)
        {

        }

        private List<Product> doSearch(String keywords)
        {
            List<Product> searchList = new List<Product>();
            List<Product> productList = new List<Product>();

            Product aProduct = new Product("eggs");
            productList.Add(aProduct);

            Product aProduct1 = new Product("egg nog");
            productList.Add(aProduct1);

            Product[] productArray = productList.ToArray();

            int size = productArray.Length;

            for(int i=0; i < size; i++)
            {
                if (productList[i].name.Contains(keywords))
                {
                    searchList.Add(productList[i]);
                }
            }

            return searchList;
        }
    }
}
