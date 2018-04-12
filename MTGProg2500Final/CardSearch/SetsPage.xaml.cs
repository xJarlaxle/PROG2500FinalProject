using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CardSearch
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SetsPage : Page
    {
        public SetsPage()
        {
            this.InitializeComponent();
        }

        private void MainPage_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void About_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(AboutPage));
        }

        private void CardSearch_Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void ViewBooster_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), boosterPackListView.ItemsSource);
        }
    }
}
