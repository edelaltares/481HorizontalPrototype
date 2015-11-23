using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemLocator
{
    public class Items
    {
        public String name;
        public String location;
        public Boolean inStock;
        public double price;
        public double salePrice;
        public int xMiniLoc;
        public int yMiniLoc;
        public int xLargeLoc;
        public int yLargeLoc;

        public Items(String newName, String newLoc, Boolean stock, double newPrice, double newSalePrice, int smallX, int smallY, int largeX, int largeY)
        {
            name = newName;
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
