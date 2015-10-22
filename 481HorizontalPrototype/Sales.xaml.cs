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
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : Page
    {
        public Sales()
        {
            InitializeComponent();

            List<SaleProduct> aList = new List<SaleProduct>();

            SaleProduct orange = new SaleProduct("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\orangepen.jpg", "Orange Pen", "$9.99", "$5.99", "Out of Stock", "Aisle 10");

            SaleProduct blue = new SaleProduct("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\bluepen.jpg", "Blue Pen", "$9.99", "$5.99", "In Stock", "Aisle 10");

            SaleProduct darkblue = new SaleProduct("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\darkbluepen.jpg", "Dark Blue Pen", "$9.99", "$5.99", "In Stock", "Aisle 10");

            SaleProduct green = new SaleProduct("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\greenpen.jpg", "Green Pen", "$9.99", "$5.99", "Out of Stock", "Aisle 10");

            SaleProduct pink = new SaleProduct("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\pinkpen.jpg", "Pink Pen", "$9.99", "$5.99", "In Stock", "Aisle 10");

            SaleProduct violet = new SaleProduct("C:\\Users\\Edel\\Documents\\Visual Studio 2015\\Projects\\WpfApplication1\\WpfApplication1\\images\\violetpen.jpg", "Violet Pen", "$9.99", "$5.99", "In Stock", "Aisle 10");


            aList.Add(orange);
            aList.Add(blue);
            aList.Add(darkblue);
            aList.Add(green);
            aList.Add(pink);
            aList.Add(violet);

            salesListBox.ItemsSource = aList;
        }
        
        private void salesback(object sender, RoutedEventArgs e)
        {
            _salesFrame.Navigate(new Results());
        }
    }

    public class SaleProduct
    {
        public SaleProduct(String location, String aName, String anOldPrice, String aNewPrice, String anAvail, String anAisle)
        {
            imagelocation = location;
            name = aName;
            oldprice = anOldPrice;
            newprice = aNewPrice;
            availability = anAvail;
            aisle = anAisle;
        }

        public String imagelocation
        {
            get;
            set;
        }
        public String name
        {
            get;
            set;
        }
        public String oldprice
        {
            get;
            set;
        }
        public String newprice
        {
            get;
            set;
        }
        public String availability
        {
            get;
            set;
        }
        public String aisle
        {
            get;
            set;
        }
    }
}
