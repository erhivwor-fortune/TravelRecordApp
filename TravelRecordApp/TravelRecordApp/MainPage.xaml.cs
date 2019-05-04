using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty("emailEntry");
            bool isPasswordEmpty = string.IsNullOrEmpty("passwordEntry");

            if (isEmailEmpty || isPasswordEmpty)
            {
                Console.WriteLine("Please enter Email or Password");
            }
            else
            {
                Navigation.PushAsync(new HomePage1());
            }
        }
    }
}
