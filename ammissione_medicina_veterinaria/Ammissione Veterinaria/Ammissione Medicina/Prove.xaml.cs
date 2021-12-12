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
    public partial class Prove : PhoneApplicationPage
    {
        public Prove()
        {
            InitializeComponent();
        }

        private void p13_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask(); webBrowserTask.Uri = new Uri("http://accessoprogrammato.miur.it/compiti/CompitoVeterinaria2013.pdf"); webBrowserTask.Show();
        }

        private void p12_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask(); webBrowserTask.Uri = new Uri("http://accessoprogrammato.miur.it/compiti/CompitoVeterinaria2012.pdf"); webBrowserTask.Show();
        }

        private void p11_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask(); webBrowserTask.Uri = new Uri("http://accessoprogrammato.miur.it/compiti/CompitoVeterinaria2011.pdf"); webBrowserTask.Show();
        }

        private void p10_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask(); webBrowserTask.Uri = new Uri("http://accessoprogrammato.miur.it/compiti/CompitoVeterinaria2010.pdf"); webBrowserTask.Show();
        }

        private void p09_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask(); webBrowserTask.Uri = new Uri("http://accessoprogrammato.miur.it/compiti/CompitoVeterinaria2009.pdf"); webBrowserTask.Show();
        }

        private void p08_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask(); webBrowserTask.Uri = new Uri("http://accessoprogrammato.miur.it/compiti/CompitoVeterinaria2008.pdf"); webBrowserTask.Show();
        }

        private void p07_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask(); webBrowserTask.Uri = new Uri("http://accessoprogrammato.miur.it/compiti/CompitoVeterinaria2007.pdf"); webBrowserTask.Show();
        }

        private void p06_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask(); webBrowserTask.Uri = new Uri("http://accessoprogrammato.miur.it/compiti/CompitoVeterinaria2006.pdf"); webBrowserTask.Show();
        }

        private void p05_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask(); webBrowserTask.Uri = new Uri("http://accessoprogrammato.miur.it/compiti/CompitoVeterinaria2005.pdf"); webBrowserTask.Show();
        }
    }
}