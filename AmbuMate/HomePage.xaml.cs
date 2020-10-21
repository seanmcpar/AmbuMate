using AmbuMate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmbuMate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        //stores current user and shift detail
        public Staff currentUserNav = new Staff();
        public Shift currentShiftNav = new Shift();
        
        //determines what stage the app is at
        //1=logged in & staff details are stored
        //2=staff details + shift details are stored
        //3=
        //4=
        //public int currentAppState;

        //initialises the HomePage when the user logs in and has not filled in any pages
        /*public HomePage(Staff currentUser)
        {
            currentAppState = 1;
            currentUserNav = currentUser;
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

            //set button image sources
            var assembly = typeof(HomePage);
            ShiftBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.shiftlogo.png", assembly);
            VehicleBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.vehiclelogo.png", assembly);
            KitBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.kitlogo.png", assembly);
            PatientsBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.patientlogo.png", assembly);
            currentUserName.Text = currentUser.FirstName[0].ToString() + ". " + currentUser.Surname; 
        }*/

        //initialises the HomePage when the user has entered shift details
        public HomePage(Staff currentUser, Shift currentShift)
        {
            currentUserNav = currentUser;
            currentShiftNav = currentShift;
            InitializeComponent(); 
            NavigationPage.SetHasBackButton(this, false);

            //set button image sources
            var assembly = typeof(HomePage);
            ShiftBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.shiftlogo.png", assembly);
            VehicleBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.vehiclelogo.png", assembly);
            KitBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.kitlogo.png", assembly);
            PatientsBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.patientlogo.png", assembly);
            currentUserName.Text = currentUser.FirstName[0].ToString() + ". " + currentUser.Surname;
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OptionsPage());
        }

        private void VehicleBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VehiclePage());
        }

        private void ShiftBtn_Clicked(object sender, EventArgs e)
        {
                Navigation.PushAsync(new ShiftPage(currentUserNav, currentShiftNav));
        }

        private void KitBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new KitPage());
        }

        private void PatientsBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PatientsPage());
        }
    }
}