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

namespace Impossible_Tris
{
    public partial class Informazioni : PhoneApplicationPage
    {
        public Informazioni()
        {
            InitializeComponent();
        }

        private void website_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            WebBrowserTask webBrowserTask = new WebBrowserTask();
            webBrowserTask.Uri = new Uri("http://rosarioterranova.altervista.org/", UriKind.Absolute);
            webBrowserTask.Show();
        }
    }
}