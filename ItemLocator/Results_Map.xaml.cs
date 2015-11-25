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
    /// Interaction logic for Results_Map.xaml
    /// </summary>
    public partial class Results_Map : UserControl
    {
        public String name
        {
            get;
            set;
        }

        public String location
        {
            get;
            set;
        }

        public String imagelocation
        {
            get;
            set;
        }

        public Boolean inStock
        {
            get;
            set;
        }

        public double price
        {
            get;
            set;
        }

        public double salePrice
        {
            get;
            set;
        }

        public int xMiniLoc
        {
            get;
            set;
        }

        public int yMiniLoc
        {
            get;
            set;
        }

        public int xLargeLoc
        {
            get;
            set;
        }

        public int yLargeLoc
        {
            get;
            set;
        }
        
        public Results_Map(Items product)
        {
            InitializeComponent();

            Product_Name.Text = product.name;
            AisleNum.Text = product.location;
           
            Product_IMG.Source = product.imagelocation;

            Product_Stock.Text = product.inStock.ToString();
            Product_Price.Text = product.price.ToString();
            xMiniLoc = product.xMiniLoc;
            yMiniLoc = product.yMiniLoc;
            xLargeLoc = product.xLargeLoc;
            yLargeLoc = product.yLargeLoc;
        }
    }
}
