using Microsoft.WindowsAzure.MobileServices;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("LilitaOne-Regular.ttf")]
[assembly: ExportFont("pakenham-free.regular.ttf")]
[assembly: ExportFont("Raleway-SemiBold.ttf")]
[assembly: ExportFont("Raleway-Regular.ttf")]
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
