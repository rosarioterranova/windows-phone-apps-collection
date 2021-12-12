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
using Windows.Devices.Geolocation;
using System.Threading.Tasks;
using Microsoft.Phone.Tasks;
using System.Device.Location;

namespace GPS_Localizer_Offline
{
    public partial class MainPage : PhoneApplicationPage
    {

        string latitudine="";
        string longitudine="";

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);

            //Shows the rate reminder message, according to the settings of the RateReminder.
            (App.Current as App).rateReminder.Notify();
            gpsready.Visibility = Visibility.Visible;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }        
        }

        private async void getcoord_Click(object sender, RoutedEventArgs e)
        {
            Geolocator geolocator = new Geolocator();
            geolocator.DesiredAccuracyInMeters = 1;
            progress.Visibility = Visibility.Visible;

            try
            {
                Geoposition geoposition = await geolocator.GetGeopositionAsync(
                maximumAge: TimeSpan.FromMinutes(5),
                timeout: TimeSpan.FromSeconds(10)
                );
                latitudine = geoposition.Coordinate.Latitude.ToString("0.0000000");
                longitudine = geoposition.Coordinate.Longitude.ToString("0.0000000");
                latid.Text = latitudine;
                longit.Text = longitudine;
                acquired.Visibility = Visibility.Visible;
            }
            catch (Exception ex)
            {
                if ((uint)ex.HResult == 0x80004004)
                {
                    progress.Visibility = Visibility.Collapsed;
                    // the application does not have the right capability or the location master switch is off
                    MessageBoxResult result = MessageBox.Show("Location  is disabled in phone settings.", "Error", MessageBoxButton.OK);
                }
            }
        }

        private void mapposition_Click(object sender, RoutedEventArgs e)
        {
            if (latid1.Text == "" || longit1.Text == "")
            {
                MessageBoxResult result = MessageBox.Show("You must enter a valid coordinates", "Error", MessageBoxButton.OK);
            }
            else
            {
                MapsTask mapsTask = new MapsTask();
                mapsTask.Center = new GeoCoordinate(double.Parse(latid1.Text), double.Parse(longit1.Text));
                mapsTask.Show();
            }
        }

        private void mapdown_Click(object sender, RoutedEventArgs e)
        {
            MapDownloaderTask mapDownloaderTask = new MapDownloaderTask();
            mapDownloaderTask.Show();
        }

        private void SMS_Click(object sender, EventArgs e)
        {
            SmsComposeTask smsComposeTask = new SmsComposeTask();
            smsComposeTask.Body = "My latitude is " + latitudine + "\nMy longitude is " + longitudine + "\nCoordinated by GPS Localizer Offline.";
            smsComposeTask.Show();
        }

        private void Mail_Click(object sender, EventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            emailComposeTask.Subject = "My GPS location with GPS Localizer Offline";
            emailComposeTask.Body = "My latitude is " + latitudine + "\nMy longitude is " + longitudine + "\nCoordinated by GPS Localizer Offline.";
            emailComposeTask.Show();
        }

        private void copyLatid_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(latid.Text);
            MessageBox.Show("Latitude copied to clipboard.");
        }

        private void copyLongit_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(longit.Text);
            MessageBox.Show("Longitude copied to clipboard.");
        }

        private void pasteLatid_Click(object sender, RoutedEventArgs e)
        {
            latid1.Text = latid.Text;
        }

        private void pasteLongit_Click(object sender, RoutedEventArgs e)
        {
            longit1.Text = longit.Text;
        }

        private void email_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            emailComposeTask.Subject = "GPS Localizer Offline Feedback";
            emailComposeTask.Body = "text";
            emailComposeTask.To = "rosario.terranova@outlook.it";
            emailComposeTask.Show();
        }

        private void facebook_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowser5 = new WebBrowserTask();
            webBrowser5.Uri = new Uri("http://rosarioterranova.blogspot.it/", UriKind.Absolute);
            webBrowser5.Show();
        }
    }
}
