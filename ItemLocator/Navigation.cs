using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ItemLocator
{
    public static class Navigation
    {
        public static Panel ContentContainer;

        private static Button backButton;

        public static Button BackButton
        {
            get
            {
                return backButton;
            }
            set
            {
                backButton = value;
                backButton.Click += BackButton_Click;
            }
        }

        private static Stack<UserControl> navStack = new Stack<UserControl>();

        public static void NavigateTo(UserControl userControl)
        {
            if (ContentContainer.Children.Count == 1 )  // if a page is loaded
            {
                navStack.Push(ContentContainer.Children[0] as UserControl);
                ContentContainer.Children.Clear();
            }

            if (navStack.Pop() != ContentContainer.Children[0])
            {
                ContentContainer.Children.Add(userControl);
            }
        }

        private static void BackButton_Click(object sender, RoutedEventArgs e)
        {
            ContentContainer.Children.Clear();
            ContentContainer.Children.Add(navStack.Pop());

            if (navStack.Count() == 0)
            {
                backButton.Visibility = Visibility.Collapsed;
            }
        }
    }
}
