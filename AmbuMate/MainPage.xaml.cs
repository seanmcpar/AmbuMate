using AmbuMate.Entities;
using AmbuMate.Logic;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AmbuMate
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            var assembly = typeof(MainPage);
            iconImage.Source = ImageSource.FromResource("AmbuMate.Assets.Images.ambumatelogo.png", assembly);
            
        }

        private async void LogInBtn_Clicked(object sender, EventArgs e)
        {
            bool login = await Staff.LogIn(idEntry.Text, passwordEntry.Text);

            if (login == true)
            {
                App.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
               await DisplayAlert("Access Denied", "The details you have entered are incorrect. Please try again.", "Ok");
            }
        }
      
    }
}
