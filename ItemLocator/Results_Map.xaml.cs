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
        public Results_Map(Items product)
        {
            InitializeComponent();

            Product_Name.Text = product.name;
            AisleNum.Text = product.location;
            int xMiniLoc = product.xMiniLoc;
            int yMiniLoc = product.yMiniLoc;
            
            Product_Stock.Text = product.getAvailability;

            if (product.salePrice != 0)
            {
                Product_OldPrice.Text = product.oldPrice.ToString();
                Product_SalePrice.Text = product.salePrice.ToString();
            }
            else
            {
                Product_Price.Text = product.price.ToString();
            }

            Product_IMG.Source = product.bi;
            Target.Margin = new Thickness(xMiniLoc, yMiniLoc, 0, 0);

        }
    }
}
