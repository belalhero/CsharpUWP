using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CSharp_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KidsDress : Page
    {
        public KidsDress()
        {
            this.InitializeComponent();
            this.Back_Button.Click += Back_Button_Click;
            this.button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Kid01Details));
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void mySearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            if (mySearchBox.QueryText != "")
            {
                if (mySearchBox.QueryText == "kids dress" || mySearchBox.QueryText == "Kids Dress" || mySearchBox.QueryText == "Kids" || mySearchBox.QueryText == "Kid" || mySearchBox.QueryText == "Kid Dress" || mySearchBox.QueryText == "Kids Cloth" || mySearchBox.QueryText == "Cloth" || mySearchBox.QueryText == "Dress" || mySearchBox.QueryText == "cloth" || mySearchBox.QueryText == "dress")
                {
                    this.Frame.Navigate(typeof(KidsDress), args.QueryText);
                }
                else
                {
                    this.Frame.Navigate(typeof(MainPage), args.QueryText);
                }
            }
        }
    }
}
