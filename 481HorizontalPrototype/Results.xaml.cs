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
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Page
    {
        public Results()
        {
            InitializeComponent();

            List<Product> aList = new List<Product>();

            Product golden = new Product("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\GoldenDelicious.jpg", "Golden Delicious Apples", "$9.99", "Out of Stock", "Produce");

            Product red = new Product("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\RedDelicious.jpg", "Red Delicious Apples", "$0.99", "In Stock", "Produce");

            Product granny = new Product("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\GrannySmith.jpg", "Granny Smith Apples", "$0.79", "In Stock", "Produce");

            Product golden1 = new Product("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\GoldenDelicious.jpg", "Golden Delicious Apples", "$9.99", "Out of Stock", "Produce");

            Product red1 = new Product("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\RedDelicious.jpg", "Red Delicious Apples", "$0.99", "In Stock", "Produce");

            Product granny1 = new Product("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\GrannySmith.jpg", "Granny Smith Apples", "$0.79", "In Stock", "Produce");

            aList.Add(golden);
            aList.Add(red);
            aList.Add(granny);
            aList.Add(golden1);
            aList.Add(red1);
            aList.Add(granny1);

            resultsListBox.ItemsSource = aList;

        }

        private void back(object sender, RoutedEventArgs e)
        {
            _resultsFrame.Navigate(new Sales());
        }

        private void itemClick(object sender, MouseButtonEventArgs e)
        {
            if (resultsListBox.SelectedItem != null)
            {
                _resultsFrame.Navigate(new ViewProduct());
            }

        }
    }
}
