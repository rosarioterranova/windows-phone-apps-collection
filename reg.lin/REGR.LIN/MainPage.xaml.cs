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
using System.Windows.Media.Imaging;
using MathNet.Numerics.Statistics;
using MathNet.Numerics.Distributions;
using System.Diagnostics.Contracts;
using MathNet.Numerics;

namespace REGR.LIN
{
    public partial class MainPage : PhoneApplicationPage
    {
        double m = 0;
        double q = 0;

        //t di student con alpha = 0,01
        double[] t = { 63.65674116, 9.924843201, 5.84090931, 4.604094871, 4.032142984, 3.707428021, 3.499483297, 3.355387331, 3.249835542, 3.169272673, 3.105806516, 3.054539589, 3.012275839, 2.976842734, 2.946712883, 2.920781622, 2.89823052, 2.878440473, 2.860934606, 2.8453397};

        double confINFq = 0;
        double confSUPq = 0;
        double confINFm = 0;
        double confSUPm = 0;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);

            //Shows the rate reminder message, according to the settings of the RateReminder.
            //(App.Current as App).rateReminder.Notify();
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }        
        }

        /// <summary>
        /// Navigates to about page.
        /// </summary>
        private void GoToAbout(object sender, GestureEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/About.xaml", UriKind.RelativeOrAbsolute));
        }

        private void calcola_Click(object sender, RoutedEventArgs e)
        {
            //lettura del texbox
            string testoArrayX = textbox_arrayX.Text.ToString();
            string testoArrayY = textbox_arrayY.Text.ToString();

            //suddivisione valori con spazio
            string[] arrayXString = testoArrayX.Split(null);
            string[] arrayYString = testoArrayY.Split(null);

            if (arrayXString.Length != arrayYString.Length) //controllo array stessa dimensione
            {
                MessageBox.Show("Le dimensioni degli array di input sono diverse", "Errore", MessageBoxButton.OK);
            }
            else if (arrayXString.Length < 3 || arrayXString.Length > 20)
            {
                MessageBox.Show("Devi inserire un totale di valori compresi tra 3 e 20", "Errore", MessageBoxButton.OK);
            }
            else
            {
                //conversione stringhe in double
                double[] arrayX = new double[arrayXString.Length];
                for (int i = 0; i < arrayXString.Length; i++)
                    arrayX[i] = double.Parse(arrayXString[i]);

                double[] arrayY = new double[arrayYString.Length];
                for (int i = 0; i < arrayYString.Length; i++)
                    arrayY[i] = double.Parse(arrayYString[i]);

                //metodo regressione lineare
                RegressioneLineare(arrayX, arrayY, arrayX.Length);

                //inserimento valori calcolati sui texbox
                textbox_m.Text = m.ToString();
                textbox_q.Text = q.ToString();
                textbox_retta.Text = "y = " + (Math.Round(m, 2)).ToString() + "x + " + (Math.Round(q, 2)).ToString();
                textbox_mediaX.Text = (arrayX.Average()).ToString();
                textbox_mediaY.Text = (arrayY.Average()).ToString();
                textbox_devX.Text = (DeviazioneStandard(arrayX)).ToString();
                textbox_devY.Text = (DeviazioneStandard(arrayY)).ToString();
                textbox_errX.Text = (ErroreStandard(arrayX, DeviazioneStandard(arrayX))).ToString();
                textbox_errY.Text = (ErroreStandard(arrayY, DeviazioneStandard(arrayY))).ToString();
                textbox_varX.Text = (Varianza(arrayX)).ToString();
                textbox_varY.Text = (Varianza(arrayY)).ToString();
                Confidenza(arrayX, arrayY, 0.01, m, q);
                textbox_sRES.Text = sres(arrayX, arrayY).ToString();
                textbox_s2x.Text = s2x(arrayX).ToString();
                textbox_INFm.Text = confINFm.ToString();
                textbox_SUPm.Text = confSUPm.ToString();
                textbox_INFq.Text = confINFq.ToString();
                textbox_SUPq.Text = confSUPq.ToString();

                //Disegno grafico
                Uri myUri = new Uri("http://chart.apis.google.com/chart?chtt=Retta+di+Regressione+Lineare&chts=000000,12&chs=300x150&chf=bg,s,ffffff|c,s,ffffff&chxt=x,y&chxl=0:|" + (arrayX.Min()).ToString() + "|" + (arrayX.Average()).ToString() + "|" + (arrayX.Max()).ToString() + "|1:|" + (arrayY.Min()).ToString() + "|" + (arrayY.Average()).ToString() + "|" + (arrayY.Max()).ToString() + "&cht=lxy&chd=t:0.00,100.00|0.00,100.00&chco=0000ff", UriKind.Absolute);
                BitmapImage bmi = new BitmapImage();
                bmi.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
                bmi.UriSource = myUri;
                grafic.Source = bmi;
            }
        }

        public void RegressioneLineare(double[] arrayX, double[] arrayY, int dimensione)
        {
            double[] XY = new double[dimensione];
            double[] XX = new double[dimensione];
            double EX = 0;
            double EY = 0;
            double EXY = 0;
            double EXX = 0;

            //calcolo array XY
            for (int i = 0; i < dimensione; i++)
                XY[i] = arrayX[i] * arrayY[i];

            //calcolo array XX
            for (int i = 0; i < dimensione; i++)
                XX[i] = arrayX[i] * arrayX[i];

            //calcolo array EX
            for (int i = 0; i < dimensione; i++)
                EX = EX + arrayX[i];

            //calcolo array EY
            for (int i = 0; i < dimensione; i++)
                EY = EY + arrayY[i];

            //calcolo array EXY
            for (int i = 0; i < dimensione; i++)
                EXY = EXY + XY[i];

            //calcolo array EXX
            for (int i = 0; i < dimensione; i++)
                EXX = EXX + XX[i];

            //calcolo m della retta
            m = ((dimensione * EXY) - (EX * EY)) / ((dimensione * EXX) - (EX * EX));

            //calcolo q della retta
            q = (EY - (m * EX)) / dimensione;
        }

        public double DeviazioneStandard(double[] array)
        {

            double ret = 0;
            if (array.Length > 0)
            {
                //Compute the Average      
                double avg = array.Average();
                //Perform the Sum of (value-avg)_2_2      
                double sum = array.Sum(d => Math.Pow(d - avg, 2));
                //Put it all together      
                ret = Math.Sqrt((sum) / (array.Length - 1));
            }
            return ret;
        }

        public double ErroreStandard(double [] array, double deviazione)
        {
            return deviazione / Math.Sqrt(array.Length);
        }

        public double Varianza(double[] array)
        {
            return array.Variance();
        }

        public double sres(double [] arrayX, double[] arrayY)
        {
            double v = 0;
            for (int i = 0; i < arrayX.Length; i++)
                v = v + Math.Pow(arrayY[i] - q - (m * arrayX[i]), 2);
            double fuoritmp = (arrayX.Length - 2);
            double fuori = 1 / fuoritmp;
            return fuori*v;
        }

        public double s2x(double[] array)
        {
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s = s + (Math.Pow(array[i] - array.Average(), 2));
            }
            return s;
        }

        public void Confidenza(double[] arrayX, double[] arrayY, double alpha, double m, double q)
        {
            //Limiti q
            confINFq = q - t[arrayX.Length-3] * Math.Sqrt(sres(arrayX, arrayY) * (1 / arrayX.Length + Math.Pow(arrayX.Average(), 2) / s2x(arrayX)));
            confSUPq = q + t[arrayX.Length-3] * Math.Sqrt(sres(arrayX, arrayY) * (1 / arrayX.Length + Math.Pow(arrayX.Average(), 2) / s2x(arrayX)));
            
            //Limiti m
            confINFm = m - t[arrayX.Length-3] * Math.Sqrt(sres(arrayX, arrayY) * (1 / s2x(arrayX)));
            confSUPm = m + t[arrayX.Length-3] * Math.Sqrt(sres(arrayX, arrayY) * (1 / s2x(arrayX)));
        }

    }
}

