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
        private Sales sales = new Sales();
        private Items[] itemsList;
        private Search search = new Search();

        public MainWindow()
        {
            InitializeComponent();
            stack1.Children.Add(search);

            Navigation.ContentContainer = stack1;
            Navigation.BackButton = backButton;

            // Items
            itemsList = new Items[43];
            Items apple = new Items("Apple", "Produce", true, 0.99, 0, 1, 1, 1, 1);
            itemsList[0] = apple;
            Items banana = new Items("Banana", "Produce", true, 0.99, 0, 1, 1, 1, 1);
            itemsList[1] = banana;
            Items rice = new Items("Rice", "Aisle 1", true, 11.99, 0, 1, 1, 1, 1);
            itemsList[2] = rice;
            Items salsa = new Items("Salsa", "Aisle 1", true, 6.99, 4.99, 1, 1, 1, 1);
            itemsList[3] = salsa;
            Items vinegar = new Items("Vinegar", "Aisle 2", true, 5.99, 0, 1, 1, 1, 1);
            itemsList[4] = vinegar;
            Items oliveOil = new Items("Olive Oil", "Aisle 2", true, 8.99, 0, 1, 1, 1, 1);
            itemsList[5] = oliveOil;
            Items tomatoSauce = new Items("Tomato Sauce", "Aisle 3", true, 3.99, 0, 1, 1, 1, 1);
            itemsList[6] = tomatoSauce;
            Items kethcup = new Items("Ketchup", "Aisle 3", true, 5.99, 0, 1, 1, 1, 1);
            itemsList[7] = kethcup;
            Items chickenSoup = new Items("Chicken Soup", "Aisle 4", true, 1.99, 0, 1, 1, 1, 1);
            itemsList[8] = chickenSoup;
            Items goldFishCrackers = new Items("Gold Fish Crakcers", "Aisle 4", true, 4.99, 0, 1, 1, 1, 1);
            itemsList[9] = goldFishCrackers;
            Items flour = new Items("Flour", "Aisle 5", true, 12.99, 0, 1, 1, 1, 1);
            itemsList[10] = flour;
            Items cannedFruit = new Items("Canned Fruit", "Aisle 5", true, 5.99, 0, 1, 1, 1, 1);
            itemsList[11] = cannedFruit;
            Items cheerios = new Items("Cheerios", "Aisle 6", false, 8.99, 5.49, 1, 1, 1, 1);
            itemsList[12] = cheerios;
            Items orangeJuice = new Items("Orange Juice", "Aisle 6", true, 7.99, 0, 1, 1, 1, 1);
            itemsList[13] = orangeJuice;
            Items coffee = new Items("Coffee", "Aisle 7", true, 6.99, 0, 1, 1, 1, 1);
            itemsList[14] = coffee;
            Items peanutButter = new Items("Peanut Butter", "Aisle 7", true, 8.99, 6.99, 1, 1, 1, 1);
            itemsList[15] = peanutButter;
            Items originalPringles = new Items("Original Pringles", "Aisle 8", false, 3.99, 1.99, 1, 1, 1, 1);
            itemsList[16] = originalPringles;
            Items doritoes = new Items("Doritoes", "Aisle 8", true, 5.99, 0, 1, 1, 1, 1);
            itemsList[17] = doritoes;
            Items distilledWater = new Items("Distilled Water", "Aisle 9", false, 9.99, 0, 1, 1, 1, 1);
            itemsList[18] = distilledWater;
            Items granolaBars = new Items("Granola Bars", "Aisle 9", true, 3.99, 0, 1, 1, 1, 1);
            itemsList[19] = granolaBars;
            Items toiletPaper = new Items("Toilet Paper", "Aisle 10", true, 7.99, 0, 1, 1, 1, 1);
            itemsList[20] = toiletPaper;
            Items catFood = new Items("Cat Food", "Aisle 10", true, 4.99, 0, 1, 1, 1, 1);
            itemsList[21] = catFood;
            Items laundryDetergent = new Items("Laundry Detergent", "Aisle 11", false, 11.99, 9.99, 1, 1, 1, 1);
            itemsList[22] = laundryDetergent;
            Items draino = new Items("Draino", "Aisle 11", true, 12.99, 0, 1, 1, 1, 1);
            itemsList[23] = draino;
            Items birthdayCards = new Items("Birthday Cards", "Aisle 12", true, 3.99, 0, 1, 1, 1, 1);
            itemsList[24] = birthdayCards;
            Items pens = new Items("Pens", "Aisle 12", true, 2.99, 0, 1, 1, 1, 1);
            itemsList[25] = pens;
            Items iceCream = new Items("Icecream", "Aisle 13", true, 6.99, 0, 1, 1, 1, 1);
            itemsList[26] = iceCream;
            Items frozenBlueberries = new Items("Frozen Blueberries", "Aisle 13", true, 7.99, 0, 1, 1, 1, 1);
            itemsList[27] = frozenBlueberries;
            Items frozenPizza = new Items("Frozen Pizza", "Aisle 14", false, 8.99, 0, 1, 1, 1, 1);
            itemsList[28] = frozenPizza;
            Items frozenFrenchFries = new Items("Frozen French Fries", "Aisle 14", false, 10.99, 6.99, 1, 1, 1, 1);
            itemsList[29] = frozenFrenchFries;
            Items eggo = new Items("Eggo", "Aisle 15", true, 4.99, 0, 1, 1, 1, 1);
            itemsList[30] = eggo;
            Items frozenJuice = new Items("Frozen Juice", "Aisle 15", true, 5.99, 0, 1, 1, 1, 1);
            itemsList[31] = frozenJuice;
            Items activiaYogurt = new Items("Activia Yogurt", "Dairy", false, 5.99, 3.00, 1, 1, 1, 1);
            itemsList[32] = activiaYogurt;
            Items milk = new Items("Milk", "Dairy", true, 6.29, 0, 1, 1, 1, 1);
            itemsList[33] = milk;
            Items shavingCream = new Items("Shaving Cream", "Pharmacy", false, 8.99, 0, 1, 1, 1, 1);
            itemsList[34] = shavingCream;
            Items deoderant = new Items("Deoderant", "Pharmacy", true, 5.99, 0, 1, 1, 1, 1);
            itemsList[35] = deoderant;
            Items bread = new Items("Bread", "Bakery", true, 9.99, 0, 1, 1, 1, 1);
            itemsList[36] = bread;
            Items muffins = new Items("Muffins", "Bakery", true, 6.99, 0, 1, 1, 1, 1);
            itemsList[37] = muffins;
            Items chickenBreast = new Items("Chicken Breast", "Meat", true, 11.99, 0, 1, 1, 1, 1);
            itemsList[38] = chickenBreast;
            Items frozenShrimp = new Items("Frozen Shrimp", "Meat", true, 14.99, 11.99, 1, 1, 1, 1);
            itemsList[39] = frozenShrimp;
            Items gouda = new Items("Gouda", "Deli", false, 12.99, 11.99, 1, 1, 1, 1);
            itemsList[40] = gouda;
            Items swissSlices = new Items("Swiss Slices", "Deli", true, 5.99, 0, 1, 1, 1, 1);
            itemsList[41] = swissSlices;
            Items meringuePowder = new Items("Meringue Powder", "Aisle 1", true, 5.99, 0, 1, 1, 1, 1);
            itemsList[42] = meringuePowder;

            search.itemsList = itemsList;
        }

        public void Navigate(UserControl nextPage)
        {
            this.Content = nextPage;
        }

        public void newPage(UserControl nextPage)
        {
            Navigation.NavigateTo(nextPage);
        }

        private void ShowMenu(object sender, RoutedEventArgs e)
        {
            if (!menuRect.IsVisible)
            {
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
                menuRect.Visibility = Visibility.Collapsed;
                homeButton.Visibility = Visibility.Collapsed;
                mapButton.Visibility = Visibility.Collapsed;
                salesButton.Visibility = Visibility.Collapsed;

                searchImage.Visibility = Visibility.Collapsed;
                mapImage.Visibility = Visibility.Collapsed;
                salesImage.Visibility = Visibility.Collapsed;
            }
        }
        
        private void HomeButtonClick(object sender, RoutedEventArgs e)
        {
            ShowMenu(sender, e);
            
            if (!backButton.IsVisible)
            {
                backButton.Visibility = Visibility.Visible;
            }

            Navigation.NavigateTo(search);
        }

        private void MapButtonClick(object sender, RoutedEventArgs e)
        {
            ShowMenu(sender, e);

            Navigation.NavigateTo(map);

            if (!backButton.IsVisible)
            {
                backButton.Visibility = Visibility.Visible;
            }
        }

        private void SalesButtonClick(object sender, RoutedEventArgs e)
        {
            ShowMenu(sender, e);

            Navigation.NavigateTo(sales);

            if (!backButton.IsVisible)
            {
                backButton.Visibility = Visibility.Visible;
            }
        }
    }
}
