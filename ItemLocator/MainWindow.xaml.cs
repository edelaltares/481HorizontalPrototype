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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Map map = new Map();
        private Sales sales;
        private Items[] itemsList = null;
        private Search search = new Search();

        public MainWindow()
        {
            InitializeComponent();
            stack1.Children.Add(search);

            Navigation.ContentContainer = stack1;
            Navigation.BackButton = backButton;

            // Items
            itemsList = new Items[20];
            Items apple = new Items("Apple", "Produce", true, 0.99, 0, 103, 67, 93, 43);
            itemsList[0] = apple;
            Items banana = new Items("Banana", "Produce", true, 0.99, 0, 237, 128, 177, 85);
            itemsList[1] = banana;
            Items rice = new Items("Rice", "Aisle 1", true, 11.99, 0, 61, 110, 99, 393);
            itemsList[2] = rice;
            Items salsa = new Items("Salsa", "Aisle 1", true, 6.99, 4.99, 216, 141, 189, 409);
            itemsList[3] = salsa;
            Items vinegar = new Items("Vinegar", "Aisle 2", true, 5.99, 0, 71, 142, 100, 374);
            itemsList[4] = vinegar;
            Items oliveOil = new Items("Olive Oil", "Aisle 2", true, 8.99, 0, 93, 142, 112, 374);
            itemsList[5] = oliveOil;
            Items tomatoSauce = new Items("Tomato Sauce", "Aisle 3", true, 3.99, 0, 223, 98, 176, 292);
            itemsList[6] = tomatoSauce;
            Items kethcup = new Items("Ketchup", "Aisle 3", true, 5.99, 0, 175, 140, 158, 338);
            itemsList[7] = kethcup;
            Items chickenSoup = new Items("Chicken Soup", "Aisle 4", true, 1.99, 0, 269, 141, 193, 274);
            itemsList[8] = chickenSoup;
            Items goldFishCrackers = new Items("Gold Fish Crackers", "Aisle 4", true, 4.99, 0, 88, 98, 111, 225);
            itemsList[9] = goldFishCrackers;
            Items flour = new Items("Flour", "Aisle 5", true, 12.99, 0, 253, 141, 184, 237);
            itemsList[10] = flour;
            Items cannedFruit = new Items("Canned Fruit", "Aisle 5", true, 5.99, 0, 32, 140, 81, 237);
            itemsList[11] = cannedFruit;
            Items cheerios = new Items("Cheerios", "Aisle 6", false, 8.99, 5.49, 192, 140, 153, 197);
            itemsList[12] = cheerios;
            Items orangeJuice = new Items("Orange Juice", "Aisle 6", true, 7.99, 0, 115, 140, 125, 182);
            itemsList[13] = orangeJuice;
            Items activiaYogurt = new Items("Activia Yogurt", "Dairy", false, 5.99, 3.00, 166, 170, 48, 262);
            itemsList[14] = activiaYogurt;
            Items milk = new Items("Milk", "Dairy", true, 6.29, 0, 166, 64, 48, 200);
            itemsList[15] = milk;
            Items bread = new Items("Bread", "Bakery", true, 9.99, 0, 101, 136, 98, 476);
            itemsList[16] = bread;
            Items muffins = new Items("Muffins", "Bakery", true, 6.99, 0, 198, 101, 172, 463);
            itemsList[17] = muffins;
            Items chickenBreast = new Items("Chicken Breast", "Meat", true, 11.99, 0, 149, 175, 42, 448);
            itemsList[18] = chickenBreast;
            Items frozenShrimp = new Items("Frozen Shrimp", "Meat", true, 14.99, 11.99, 172, 212, 56, 477);
            itemsList[19] = frozenShrimp;

            sales = new Sales(itemsList);
            search.itemsList = itemsList;
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void newPage(UserControl nextPage)
        {
            if (!backButton.IsVisible)
            {
                backButton.Visibility = Visibility.Visible;
            }

            Navigation.NavigateTo(nextPage);
        }

        private void ShowMenu(object sender, RoutedEventArgs e)
        {
            if (!menuRect.IsVisible)
            {
                closeMenuRect.Visibility = Visibility.Visible;
                menuRect.Visibility = Visibility.Visible;
                homeButton.Visibility = Visibility.Visible;
                mapButton.Visibility = Visibility.Visible;
                salesButton.Visibility = Visibility.Visible;

                searchImage.Visibility = Visibility.Visible;
                mapImage.Visibility = Visibility.Visible;
                salesImage.Visibility = Visibility.Visible;
            }
            else
            {
                closeMenuRect.Visibility = Visibility.Collapsed;
                menuRect.Visibility = Visibility.Collapsed;
                homeButton.Visibility = Visibility.Collapsed;
                mapButton.Visibility = Visibility.Collapsed;
                salesButton.Visibility = Visibility.Collapsed;

                searchImage.Visibility = Visibility.Collapsed;
                mapImage.Visibility = Visibility.Collapsed;
                salesImage.Visibility = Visibility.Collapsed;
            }
        }

        private void stopMenu()
        {
            closeMenuRect.Visibility = Visibility.Collapsed;
            menuRect.Visibility = Visibility.Collapsed;
            homeButton.Visibility = Visibility.Collapsed;
            mapButton.Visibility = Visibility.Collapsed;
            salesButton.Visibility = Visibility.Collapsed;

            searchImage.Visibility = Visibility.Collapsed;
            mapImage.Visibility = Visibility.Collapsed;
            salesImage.Visibility = Visibility.Collapsed;
        }
        
        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            if (!backButton.IsVisible)
            {
                backButton.Visibility = Visibility.Visible;
            }

            stopMenu();

            Navigation.NavigateTo(search);
        }

        private void MapButtonClick(object sender, RoutedEventArgs e)
        {
            if (!backButton.IsVisible)
            {
                backButton.Visibility = Visibility.Visible;
            }

            stopMenu();

            Navigation.NavigateTo(map);
        }

        private void SalesButtonClick(object sender, RoutedEventArgs e)
        {
            if (!backButton.IsVisible)
            {
                backButton.Visibility = Visibility.Visible;
            }

            if (sales.salesListBox.ItemsSource == null)
            {
                sales.salesListBox.ItemsSource = sales.findSales();
            }

            stopMenu();

            Navigation.NavigateTo(sales);
        }
        
        public Items[] getItems()
        {
            return itemsList;
        }

        private void closeMenu(object sender, MouseButtonEventArgs e)
        {
            stopMenu();
        }
    }
}
