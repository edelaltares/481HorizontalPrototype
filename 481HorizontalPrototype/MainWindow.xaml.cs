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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _mainFrame.Navigate(new SearchBar());
        }

    }

    public class Product
    {
        public Product(String location,String aName, String aPrice, String anAvail, String anAisle)
        {
            imagelocation = location;
            name = aName;
            price = aPrice;
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
        public String price
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
