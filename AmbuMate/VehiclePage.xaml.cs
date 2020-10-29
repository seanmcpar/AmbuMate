using AmbuMate.Entities;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmbuMate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehiclePage : ContentPage
    {
        public VehiclePage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
           
                if (App.currentVehicle.ID!=null)
                {
                        RegNoEntry.Text = App.currentVehicle.RegNumber;
                    if (App.currentVehicle.StartMileage!=0) { StartMileageEntry.Text = App.currentVehicle.StartMileage.ToString(); }
                    if (App.currentVehicle.EndMileage != 0) { EndMileageEntry.Text = App.currentVehicle.EndMileage.ToString(); }
                        LightsSwitch.IsToggled = App.currentVehicle.Lights;
                        SignalsSwitch.IsToggled = App.currentVehicle.Signals;
                        SirensSwitch.IsToggled = App.currentVehicle.Signals;
                        FireExtSwitch.IsToggled = App.currentVehicle.FireExtinguisher;
                        WarnTriangleSwitch.IsToggled = App.currentVehicle.WarningTriangle;
                        FireBlanketSwitch.IsToggled = App.currentVehicle.FireBlanket;
                        VehicleCleanedSwitch.IsToggled = App.currentVehicle.Clean;
                        DeepCleanSwitch.IsToggled = App.currentVehicle.DeepClean;
                    if (App.currentVehicle.Fuel != 0) { FuelSlider.Value = App.currentVehicle.Fuel; }
                    if (App.currentVehicle.VehicleNotes != null){ VehicleNotesEntry.Text = App.currentVehicle.VehicleNotes;}
                }

        }

        private void FuelSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            FuelLabel.Text = "Fuel:\r\n" + Convert.ToInt32(FuelSlider.Value) + "%";
        }


        //stores entered user details in SQLite Shift Table
        protected override bool OnBackButtonPressed()
        {
            App.currentVehicle = CurrentVehicleDetails();
            Navigation.PushAsync(new HomePage());
            return true;
        }

        private Vehicle CurrentVehicleDetails()
        {
            Vehicle vehicle = new Vehicle();
            {
                vehicle.RegNumber = vehicle.RegNumber;
                if (int.TryParse(StartMileageEntry.Text, out int startMileage))
                {
                    vehicle.StartMileage = startMileage;
                }
                if (int.TryParse(EndMileageEntry.Text, out int endMileage))
                {
                    vehicle.EndMileage = endMileage;
                }
                vehicle.Lights = LightsSwitch.IsToggled;
                vehicle.Signals = SignalsSwitch.IsToggled;
                vehicle.Signals = SirensSwitch.IsToggled;
                vehicle.FireExtinguisher = FireExtSwitch.IsToggled;
                vehicle.WarningTriangle = WarnTriangleSwitch.IsToggled;
                vehicle.FireBlanket = FireBlanketSwitch.IsToggled;
                vehicle.Clean = VehicleCleanedSwitch.IsToggled;
                vehicle.DeepClean = DeepCleanSwitch.IsToggled;
                vehicle.Fuel = Convert.ToInt32(FuelSlider.Value);
                vehicle.VehicleNotes = VehicleNotesEntry.Text;
            }
            return vehicle;
        }
    }

}
