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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CSharp_Project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.button4.Click += button4_click;
            this.button3.Click += Button3_Click;
            this.button2.Click += Button2_Click;
            this.button1.Click += Button1_Click;
            this.login.Click += Login_Click;
        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            if(username.Text == "Admin" && password.Password=="12345")
            {
                this.Frame.Navigate(typeof(EmployeeInformation));
            }
            else if (username.Text == "" && password.Password == "")
            {
                ContentDialog dialog = new ContentDialog()
                {

                    Title = "Error!!",
                    MaxWidth = this.ActualWidth,
                    Height = this.ActualHeight,
                    PrimaryButtonText = "Ok",
                    Content = new TextBlock
                    {
                        Text = "Please Enter Username and Password!!!",
                        FontSize = 25
                    },
                };
                await dialog.ShowAsync();
            }
            else
            {
                //string message = "Invalid Username or Passoward!!";
                ContentDialog dialog = new ContentDialog()
                {
                   
                    Title = "Error!!", MaxWidth = this.ActualWidth, Height = this.ActualHeight, PrimaryButtonText = "Ok",
                    Content = new TextBlock
                    {
                        Text = "Incorrect Username or Password!!!",
                        FontSize = 25                        
                    },
                };
                await dialog.ShowAsync();
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DetailsMouse));
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DetailsKeyboard));
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DetailsHDD));
        }

        private void button4_click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Details));
        }

        private void About_click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = true;
        }

        private void Category_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = false;
            this.Frame.Navigate(typeof(KidsDress));
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = true;
        }

        private void mySearchBox_QuerySubmitted(SearchBox sender, SearchBoxQuerySubmittedEventArgs args)
        {
            if(mySearchBox.QueryText != "")
            {
                if(mySearchBox.QueryText == "kids dress" || mySearchBox.QueryText== "Kids Dress" || mySearchBox.QueryText == "Kids" || mySearchBox.QueryText == "Kid" || mySearchBox.QueryText == "Kid Dress" || mySearchBox.QueryText == "Kids Cloth" || mySearchBox.QueryText == "Cloth" || mySearchBox.QueryText == "Dress" || mySearchBox.QueryText == "cloth" || mySearchBox.QueryText == "dress")
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
