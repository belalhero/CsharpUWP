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
    public sealed partial class DetailsKeyboard : Page
    {
        public DetailsKeyboard()
        {
            this.InitializeComponent();
            this.Back_Button.Click += Back_Button_Click;
            this.details1.Click += Details1_Click;
            this.details2.Click += Details2_Click;
            this.details3.Click += Details3_Click;
            this.BuyNow_Btn.Click += BuyNow_Btn_Click;
        }

        private void BuyNow_Btn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PaymentDetails));
        }

        private void Details3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Details2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Details1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image image = sender as Image;
            Panel parent = image.Parent as Panel;
            if (parent != null)
            {
                image.RenderTransform = new ScaleTransform() { ScaleX = 5, ScaleY = 5 };
                parent.Children.Remove(image);
                parent.Children.Add(new Popup() { Child = image, IsOpen = true, Tag = parent });
            }
            else
            {
                Popup popup = image.Parent as Popup;
                popup.Child = null;
                Panel panel = popup.Tag as Panel;
                image.RenderTransform = null;
                panel.Children.Add(image);
            }
        }
    }
}
