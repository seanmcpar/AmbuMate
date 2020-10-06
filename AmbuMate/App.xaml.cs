using Microsoft.WindowsAzure.MobileServices;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmbuMate
{
    public partial class App : Application
    {
        public static MobileServiceClient MobileService = new MobileServiceClient("https://ambumatemobileapp.azurewebsites.net");
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage( new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
