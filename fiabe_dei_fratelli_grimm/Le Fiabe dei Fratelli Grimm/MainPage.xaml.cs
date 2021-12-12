using Microsoft.Phone.Tasks;
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
using Telerik.Windows.Controls;
using Microsoft.Phone.Controls;


namespace Le_Fiabe_dei_Fratelli_Grimm
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Costruttore
        public MainPage()
        {
            InitializeComponent();

            InteractionEffectManager.AllowedTypes.Add(typeof(StackPanel));

            // Impostare il contesto dei dati nel controllo casella di riepilogo su dati di esempio
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
            RadRateApplicationReminder rateReminder = new RadRateApplicationReminder();
            rateReminder.RecurrencePerUsageCount = 10;
            rateReminder.MessageBoxInfo.Content = "Ciao, sembra che tu utilizzi spesso questa app! Perché non la voti con 5 stelle in modo da incentivare lo svillupatore a lavorarci di più?";
            rateReminder.MessageBoxInfo.Title = "Hey!";
            rateReminder.Notify();
        }

        // Caricare i dati per gli elementi ViewModel
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void indx001_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 0;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx002_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 1;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx003_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 2;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx004_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 3;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx005_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 4;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx006_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 5;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx007_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 6;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx008_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 7;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx009_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 8;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx010_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 9;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx011_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 10;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx012_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 11;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx013_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 12;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx014_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 13;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx015_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 14;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx016_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 15;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx017_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 16;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx018_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 17;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx019_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 18;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx020_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 19;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx021_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 20;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx022_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 21;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx023_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 22;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx024_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 23;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx025_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 24;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx026_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 25;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx027_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 26;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx028_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 27;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx029_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 28;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx030_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 29;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx031_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 30;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx032_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 31;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx033_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 32;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx034_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 33;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx035_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 34;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx036_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 35;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx037_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 36;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx038_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 37;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx039_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 38;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx040_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 39;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx041_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 40;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx042_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 41;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx043_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 42;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx044_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 43;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx045_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 44;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx046_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 45;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx047_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 46;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx048_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 47;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx049_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 48;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx050_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 49;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx051_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 50;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx052_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 51;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx053_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 52;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx054_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 53;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx055_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 54;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx056_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 55;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx057_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 56;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx058_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 57;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx059_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 58;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx060_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 59;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx061_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 60;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx062_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 61;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx063_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 62;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx064_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 63;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx065_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 64;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx066_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 65;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx067_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 66;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx068_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 67;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx069_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 68;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx070_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 69;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx071_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 70;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx072_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 71;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx073_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 72;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx074_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 73;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx075_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 74;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx076_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 75;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx077_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 76;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx078_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 77;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx079_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 78;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx080_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 79;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx081_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 80;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx082_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 81;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx083_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 82;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx084_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 83;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx085_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 84;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx086_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 85;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx087_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 86;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx088_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 87;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx089_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 88;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx090_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 89;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx091_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 90;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx092_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 91;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx093_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 92;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx094_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 93;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx095_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 94;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx096_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 95;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx097_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 96;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx098_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 97;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx099_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 98;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx100_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 99;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx101_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 100;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx102_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 101;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx103_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 102;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx104_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 103;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx105_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 104;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx106_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 105;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx107_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 106;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx108_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 107;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx109_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 108;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx110_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 109;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx111_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 110;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx112_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 111;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx113_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 112;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx114_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 113;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx115_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 114;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx116_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 115;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx117_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 116;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx118_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 117;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx119_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 118;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx120_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 109;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx121_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 120;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx122_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 121;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx123_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 122;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx124_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 123;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx125_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 124;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx126_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 125;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx127_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 126;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx128_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 127;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx129_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 128;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx130_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 129;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx131_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 130;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx132_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 131;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx133_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 132;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx134_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 133;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx135_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 134;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx136_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 135;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx137_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 136;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx138_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 137;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx139_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 138;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx140_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 139;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx141_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 140;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx142_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 141;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx143_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 142;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx144_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 143;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx145_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 144;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx146_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 145;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx147_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 146;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx148_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 147;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx149_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 148;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx150_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 149;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx151_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 150;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx152_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 151;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx153_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 152;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx154_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 153;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx155_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 154;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx156_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 155;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx157_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 156;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx158_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 157;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx159_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 158;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx160_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 159;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }
      
        private void indx161_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 160;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx162_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 161;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx163_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 162;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx164_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 163;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx165_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 164;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx166_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 165;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx167_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 166;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx168_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 167;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx169_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 168;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx170_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 169;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx171_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 170;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx172_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 171;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx173_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 172;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx174_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 173;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx175_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 174;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx176_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 175;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx177_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 176;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx178_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 177;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx179_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 178;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx180_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 179;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx181_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 180;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx182_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 181;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx183_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 182;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx184_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 183;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx185_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 184;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx186_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 185;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx187_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 186;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx188_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 187;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx189_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 188;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx190_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 189;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }
         
        private void indx191_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 190;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx192_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 191;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx193_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 192;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx194_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 193;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx195_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 194;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx196_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 195;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx197_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 196;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx198_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 197;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx199_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 198;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx200_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 199;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx201_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 200;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx202_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 201;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx203_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 202;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx204_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 203;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx205_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 204;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx206_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 205;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx207_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 206;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx208_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 207;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx209_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 208;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx210_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 209;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indx211_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            App.globalIndex = 210;
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void sfoglia_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Fiabe.xaml", UriKind.Relative));
        }

        private void indiceB_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Panorama.DefaultItem = Panorama.Items[1]; 
        }

        private void store_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
                MarketplaceSearchTask marketplaceSearchTask = new MarketplaceSearchTask();
                marketplaceSearchTask.SearchTerms = "rosario terranova";
                marketplaceSearchTask.Show();
        }

        private void vota_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            MarketplaceReviewTask marketplaceReviewTask = new MarketplaceReviewTask();
            marketplaceReviewTask.Show();
        }

        private void contattami_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            EmailComposeTask emailComposeTask = new EmailComposeTask();
            emailComposeTask.Subject = "grimm feedback";
            emailComposeTask.Body = "testo";
            emailComposeTask.To = "rosario.terranova@outlook.it";
            emailComposeTask.Show();
        }
    }
}