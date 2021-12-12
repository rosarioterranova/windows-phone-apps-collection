using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Tris_Classic
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Costruttore
        public MainPage()
        {
            InitializeComponent();
        }

        private void singleButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GiocoSingolo.xaml", UriKind.Relative));
        }

        private void multiButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Multigiocatore.xaml", UriKind.Relative));
        }

        private void facileButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Facile.xaml", UriKind.Relative));
        }

        private void infoButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Informazioni.xaml", UriKind.Relative));
        }
    }
}