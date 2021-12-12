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
using System.IO;
using System.ServiceModel.Syndication;
using System.Xml;
using Microsoft.Phone.Tasks;
using Telerik.Windows.Controls;
using RateMyApp.Controls;


namespace Ammissione_Medicina
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Costruttore
        public MainPage()
        {
            InitializeComponent();
            InteractionEffectManager.AllowedTypes.Add(typeof(StackPanel));
            
            DataContext = App.ViewModel;

            votami.VisibilityChanged += FeedbackOverlay_VisibilityChanged;
            news.Navigated += new EventHandler<System.Windows.Navigation.NavigationEventArgs>(Browser_Navigated);
            news.Navigating += new EventHandler<NavigatingEventArgs>(Browser_Navigating);
        }

        void Browser_Navigating(object sender, NavigatingEventArgs e)
        {
            ProgBar.Visibility = Visibility.Visible;
        }

        void Browser_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            ProgBar.Visibility = Visibility.Collapsed;
        }


        void FeedbackOverlay_VisibilityChanged(object sender, EventArgs e)
        {
           votami.Visibility = Visibility.Visible;
        }

        
        private void loadFeedButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (HasInternetConection == true)
            {
                logo.Visibility = Visibility.Collapsed;
                news.Visibility = Visibility.Visible;
                loadFeedButton.Content = "ricarica notizie";
                news.Navigate(new Uri("http://rosarioterranova.altervista.org/apps_data/ammissione_medicina_news.html", UriKind.Absolute));
            }
            else MessageBox.Show("Sembra che tu non sia connesso alla rete, impossibile recuperare le news.", "Errore di rete", MessageBoxButton.OK);
        }

        public static bool HasInternetConection
        {
            get
            {
                return (Microsoft.Phone.Net.NetworkInformation.NetworkInterface.NetworkInterfaceType != Microsoft.Phone.Net.NetworkInformation.NetworkInterfaceType.None);
            }
        }

        private void bandoPannel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask(); webBrowserTask.Uri = new Uri("http://attiministeriali.miur.it/media/232504/decreto_05022014_allegati.pdf"); webBrowserTask.Show();
        }

        private void provePannel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Prove.xaml", UriKind.Relative));
        }

        private void datePannel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Date.xaml", UriKind.Relative));
        }

        private void punteggiMinPannel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PuntMinim.xaml", UriKind.Relative));
        }

        private void votaApp_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }

        private void rtsoft_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/rtsoft.xaml", UriKind.Relative));
        }

        private void contattami_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            emailComposeTask.Subject = "Ammissione Medicina Feedback";
            emailComposeTask.Body = "";
            emailComposeTask.To = "rosario.terranova@outlook.it";
            emailComposeTask.Show();
        }

        private void altreapp_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceSearchTask marketplaceSearchTask = new MarketplaceSearchTask();
            marketplaceSearchTask.SearchTerms = "rosario terranova";
            marketplaceSearchTask.Show();
        }

        private void borsaPannel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask webBrowser1 = new WebBrowserTask();
            webBrowser1.Uri = new Uri("https://www.universitaly.it/index.php/public/dirittoallostudio", UriKind.Absolute);
            webBrowser1.Show();
        }

        private void faqPannel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask webBrowser1 = new WebBrowserTask();
            webBrowser1.Uri = new Uri("http://www.universitaly.it/index.php/public/allfaq", UriKind.Absolute);
            webBrowser1.Show();
        }

        private void modalitaPannel_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/modal.xaml", UriKind.Relative));
        }

    }
}