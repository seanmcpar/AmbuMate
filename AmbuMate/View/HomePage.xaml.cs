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
        
        //initialises the HomePage when the user has entered shift details
        public HomePage()
        {
            InitializeComponent(); 
            NavigationPage.SetHasBackButton(this, false);

            //set button image sources
            var assembly = typeof(HomePage);
            ShiftBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.shiftlogo.png", assembly);
            VehicleBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.vehiclelogo.png", assembly);
            KitBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.kitlogo.png", assembly);
            PatientsBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.patientlogo.png", assembly);

            //current users name displays at the top of the screen
            currentUserName.Text = App.currentUser.FirstName[0].ToString() + ". " + App.currentUser.Surname;
        }

        //Reads AmbuMate database and fills App data fields with relevant shift information
        protected async override void OnAppearing()
        {
            Shift dbShift = (await App.MobileService.GetTable<Shift>().Where(s => s.AttendantID == App.currentUser.ID && (s.ShiftDate == DateTime.Today || s.ShiftDate == DateTime.Today.AddDays(-1)) && s.ShiftStatus == "Active").ToListAsync()).FirstOrDefault();
            
                if (dbShift != null)
                {
                    App.currentShift = dbShift;
                    Vehicle currentVehicle = (await App.MobileService.GetTable<Vehicle>().Where(v => v.ShiftID == App.currentShift.Id).ToListAsync()).FirstOrDefault();
                    Kit currentKit = (await App.MobileService.GetTable<Kit>().Where(k => k.ShiftID == App.currentShift.Id).ToListAsync()).FirstOrDefault();
                    App.currentVehicle = currentVehicle;
                    App.currentKit = currentKit;
                }

            if (App.currentShift != null)
                {
                if (App.currentVehicle == null) {
                    Vehicle currentVehicle = (await App.MobileService.GetTable<Vehicle>().Where(v => v.ShiftID == App.currentShift.Id).ToListAsync()).FirstOrDefault();
                    App.currentVehicle = currentVehicle;
                }
                if (App.currentKit == null) {
                    Kit currentKit = (await App.MobileService.GetTable<Kit>().Where(k => k.ShiftID == App.currentShift.Id).ToListAsync()).FirstOrDefault();
                    App.currentKit = currentKit;
                }
            }
            base.OnAppearing();
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
                Navigation.PushAsync(new ShiftPage());
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