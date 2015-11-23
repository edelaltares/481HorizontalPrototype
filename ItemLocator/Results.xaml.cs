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
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : UserControl
    {

        public Results()
        {
            InitializeComponent();
        }

        public Results(List<Items> result, String searchWord)
        {
            InitializeComponent();

            if (result != null)
            {
                resultsListBox.ItemsSource = result;
                keywordLabel.Content = searchWord;
                resultSearch.Text = searchWord;
            }
        }

        private void clickBack(object sender, RoutedEventArgs e)
        {

        }

        private void itemClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
