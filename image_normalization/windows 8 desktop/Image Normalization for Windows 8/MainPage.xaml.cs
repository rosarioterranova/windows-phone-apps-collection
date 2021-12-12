using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Il modello di elemento per la pagina vuota è documentato all'indirizzo http://go.microsoft.com/fwlink/?LinkId=234238

namespace Image_Normalization_for_Windows_8
{
    /// <summary>
    /// Pagina vuota che può essere utilizzata autonomamente oppure esplorata all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Richiamato quando la pagina sta per essere visualizzata in un Frame.
        /// </summary>
        /// <param name="e">Dati dell'evento in cui vengono descritte le modalità con cui la pagina è stata raggiunta. La proprietà
        /// Parameter viene in genere utilizzata per configurare la pagina.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
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
            risultato.Text = "";
        }
    }
}
