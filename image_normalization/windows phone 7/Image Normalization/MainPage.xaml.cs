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
using Microsoft.Phone.Tasks;

namespace Image_Normalization
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Costruttore
        public MainPage()
        {
            InitializeComponent();

            // Impostare il contesto dei dati nel controllo casella di riepilogo su dati di esempio
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Caricare i dati per gli elementi ViewModel
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void normalizzaButton_Click(object sender, RoutedEventArgs e)
        {
            if (val.Text != "" && min.Text != "" && max.Text != "")
            {
                double n = double.Parse(val.Text);
                double minim = double.Parse(min.Text);
                double massim = double.Parse(max.Text);
                double ris = (255 * ((n - minim) / (massim - minim)));
                risultato.Text = ris.ToString();
            }
	    }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            val.Text = "";
            min.Text = "";
            max.Text = "";
            risultato.Text ="";
        }

        private void siteweb_Tap(object sender, GestureEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://rosarioterranova.altervista.org/", UriKind.Absolute);
            webBrowserTask.Show();
        }
    }
}