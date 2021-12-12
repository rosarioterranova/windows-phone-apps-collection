using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace Ammissione_Medicina
{
    public partial class rtsoft : PhoneApplicationPage
    {
        public rtsoft()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            wb1.Navigate(new Uri("http://rosarioterranova.altervista.org/news.html", UriKind.Absolute));
        }

        private void contattamiButton_Click(object sender, RoutedEventArgs e)
        {
              EmailComposeTask emailComposeTask = new EmailComposeTask();

            emailComposeTask.Subject = "feedback da Ammissione Medicina";
            emailComposeTask.Body = "";
            emailComposeTask.To = "rosario.terranova@outlook.it";
            emailComposeTask.Cc = "";
            emailComposeTask.Bcc = "";
            emailComposeTask.Show();
        }

        private void mieappButton_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceSearchTask marketplaceSearchTask = new MarketplaceSearchTask();
            marketplaceSearchTask.SearchTerms = "rosario terranova";
            marketplaceSearchTask.Show();
        }
    }
}