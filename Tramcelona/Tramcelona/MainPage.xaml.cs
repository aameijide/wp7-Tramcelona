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

namespace Tramcelona
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        void OnT1ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/T1.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnT2ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/T2.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnT3ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/T3.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnT4ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/T4.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnT5ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/T5.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }

        void OnT6ManipulationStarted(object sender, ManipulationStartedEventArgs args)
        {
            this.NavigationService.Navigate(new Uri("/T6.xaml", UriKind.Relative));

            args.Complete();
            args.Handled = true;
        }
    }
}