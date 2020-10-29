using AmbuMate.Entities;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
        public static string DatabaseLocation = string.Empty;
        public static Staff currentUser = new Staff();
        public static Shift currentShift = new Shift();
        public static Vehicle currentVehicle = new Vehicle();
        public static Kit currentKit = new Kit();
        public static List<Patient> currentPatients = new List<Patient>();
        public App() 
        {
            InitializeComponent();
            MainPage = new NavigationPage( new MainPage());
        }

        public App(string databaseLocation)
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
            DatabaseLocation = databaseLocation;
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
