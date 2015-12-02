using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace ItemLocator
{
    public class Items
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

        public Boolean inStock
        {
            get;
            set;
        }
        
        public String getAvailability
        {
            get;
            set;
        }

        public double price
        {
            get;
            set;
        }

        public double oldPrice
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

        public ImageSource imageLocation
        {
            get;
            set;
        }

        public BitmapImage bi
        {
            get;
            set;
        }

        public Boolean onSale
        {
            get;
            set;
        }


        public Items(String newName, String newLoc, Boolean stock, double newPrice, double newSalePrice, int smallX, int smallY, int largeX, int largeY)
        {
            name = newName;

            String imagelocation = "images/Products/" + newName.ToLower().Replace(' ', '-') + ".png";
            Image prodImg = new Image();
            bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(imagelocation, UriKind.Relative);
            bi.EndInit();
            imageLocation = bi;

            location = newLoc;

            if(stock)
            {
                getAvailability = "In Stock";
            }
            else
            {
                getAvailability = "Out of Stock";
            }

            if (newSalePrice != 0)
            {
                price = newPrice;
                onSale = true;
            }
            else
            {
                price = newPrice;
                onSale = false;
            }

            oldPrice = newPrice;
            salePrice = newSalePrice;
            xMiniLoc = smallX;
            yMiniLoc = smallY;
            xLargeLoc = largeX;
            yLargeLoc = largeY;
        }

        public Boolean isInStock()
        {
            return inStock;
        }

        public Boolean isOnSale()
        {
            return (salePrice != 0);
        }
    }
}
