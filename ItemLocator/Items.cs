using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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

        public BitmapImage img
        {
            get;
            set;
        }

        public BitmapImage defaultImg
        {
            get;
            set;
        }


        public Items(String newName, String newLoc, Boolean stock, double newPrice, double newSalePrice, int smallX, int smallY, int largeX, int largeY)
        {
            name = newName;
            /*
            String imgPath = "images/Products/" + newName.ToLower().Replace(' ', '_') + ".png";
            Uri imgUri = new Uri(imgPath, UriKind.Relative);
            BitmapImage imgBitmap = new BitmapImage(imgUri); */
            imagelocation = "images/Products/" + newName.ToLower().Replace(' ', '_') + ".png";

            BitmapImage img = new BitmapImage(new Uri(imagelocation, UriKind.Relative));

            String defaultimg = "images/Products/unknown.png";

            BitmapImage defaultImg = new BitmapImage(new Uri(defaultimg, UriKind.Relative));

            location = newLoc;
            inStock = stock;
            price = newPrice;
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
