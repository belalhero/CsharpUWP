﻿using System;
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
    public sealed partial class PaymentDetails : Page
    {
        public PaymentDetails()
        {
            this.InitializeComponent();
            this.back2.Click += Back2_Click;
            this.ConfirmBtn.Click += ConfirmBtn_Click;
        }

        private void ConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ThankYouPage));
        }

        private void Back2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Details));
        }
    }
}
