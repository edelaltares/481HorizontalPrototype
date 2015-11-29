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

            /// <summary>
            ///  the following ifs Adjust map images and hide labels appropriately
            /// </summary>
            if (!product.location.ToLower().Contains("aisle")) /// if not contain aisle
            {
                topAisle.Visibility = System.Windows.Visibility.Hidden;
                midAisle.Visibility = System.Windows.Visibility.Hidden;
                bottomAisle.Visibility = System.Windows.Visibility.Hidden;

                if (product.location.ToLower().Contains("bakery"))
                {
                    MiniMap.Source = new BitmapImage(new Uri(@"\images\store\Bakery.png", UriKind.Relative));
                }

                else if (product.location.ToLower().Contains("meat"))
                {
                    MiniMap.Source = new BitmapImage(new Uri(@"\images\store\Meats.png", UriKind.Relative));
                }

                else if (product.location.ToLower().Contains("dairy"))
                {
                    MiniMap.Source = new BitmapImage(new Uri(@"\images\store\Dairy.png", UriKind.Relative));
                }

                else if (product.location.ToLower().Contains("produce"))
                {
                    MiniMap.Source = new BitmapImage(new Uri(@"\images\store\Produce.png", UriKind.Relative));
                }

                else if (product.location.ToLower().Contains("spindle"))
                {
                    MiniMap.Source = new BitmapImage(new Uri(@"\images\store\spindles.png", UriKind.Relative));
                }
            }
            /// <summary>
            ///  the following adjust the numbers in the labels.
            /// </summary>
            else /// We know it's in aisle because of previous if statement.
            {
                if (product.location.ToLower().Contains("1"))
                {
                    bottomAisle.Content = "▼Bakery▼";
                    midAisle.Content = "1";
                    topAisle.Content = "2";
                    bottomAisle.Foreground = System.Windows.Media.Brushes.SaddleBrown;
                }

                else if (product.location.ToLower().Contains("2"))
                {
                    bottomAisle.Content = "1";
                    midAisle.Content = "2";
                    topAisle.Content = "3";
                }

                else if (product.location.ToLower().Contains("3"))
                {
                    bottomAisle.Content = "2";
                    midAisle.Content = "3";
                    topAisle.Content = "4";
                }

                else if (product.location.ToLower().Contains("4"))
                {
                    bottomAisle.Content = "3";
                    midAisle.Content = "4";
                    topAisle.Content = "5";
                }

                else if (product.location.ToLower().Contains("5"))
                {
                    bottomAisle.Content = "4";
                    midAisle.Content = "5";
                    topAisle.Content = "6";
                }
                else if (product.location.ToLower().Contains("6"))
                {
                    bottomAisle.Content = "5";
                    midAisle.Content = "6";
                    topAisle.Content = "▲PRODUCE▲";
                    topAisle.Foreground = System.Windows.Media.Brushes.ForestGreen;
                }
            }
        }

        private void fullMapButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = (MainWindow)Window.GetWindow(this);

            Map Map = new Map();

            main.newPage(Map);
        }
    }
}
