﻿#pragma checksum "C:\Users\Rosario\documents\visual studio 2012\Projects\GPS Localizer Offline\GPS Localizer Offline\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8B6D45BF02943B0C9F39A389F973DDFC"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.34014
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace GPS_Localizer_Offline {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.PivotItem get;
        
        internal System.Windows.Controls.TextBox latid;
        
        internal System.Windows.Controls.TextBox longit;
        
        internal System.Windows.Controls.Button getcoord;
        
        internal Microsoft.Phone.Controls.PivotItem localize;
        
        internal System.Windows.Controls.ListBox FirstListBox;
        
        internal Microsoft.Phone.Controls.PivotItem about;
        
        internal System.Windows.Controls.ListBox SecondListBox;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/GPS%20Localizer%20Offline;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.get = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("get")));
            this.latid = ((System.Windows.Controls.TextBox)(this.FindName("latid")));
            this.longit = ((System.Windows.Controls.TextBox)(this.FindName("longit")));
            this.getcoord = ((System.Windows.Controls.Button)(this.FindName("getcoord")));
            this.localize = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("localize")));
            this.FirstListBox = ((System.Windows.Controls.ListBox)(this.FindName("FirstListBox")));
            this.about = ((Microsoft.Phone.Controls.PivotItem)(this.FindName("about")));
            this.SecondListBox = ((System.Windows.Controls.ListBox)(this.FindName("SecondListBox")));
        }
    }
}

