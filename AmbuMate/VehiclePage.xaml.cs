﻿using AmbuMate.Entities;
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
        public Vehicle vehicleData;
        public VehiclePage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

           vehicleData = App.currentVehicle;
            if (vehicleData!=null)
                {
                        RegNoEntry.Text = App.currentVehicle.Registration;
                    if (App.currentVehicle.StartMileage!=0) { StartMileageEntry.Text = App.currentVehicle.StartMileage.ToString(); }
                    if (App.currentVehicle.EndMileage != 0) { EndMileageEntry.Text = App.currentVehicle.EndMileage.ToString(); }
                        LightsSwitch.IsToggled = bool.Parse(App.currentVehicle.Lights);
                        SignalsSwitch.IsToggled = bool.Parse(App.currentVehicle.Signals);
                        SirensSwitch.IsToggled = bool.Parse(App.currentVehicle.Signals);
                        FireExtSwitch.IsToggled = bool.Parse(App.currentVehicle.FireExtinguisher);
                        WarnTriangleSwitch.IsToggled = bool.Parse(App.currentVehicle.WarningTriangle);
                        FireBlanketSwitch.IsToggled = bool.Parse(App.currentVehicle.FireBlanket);
                        VehicleCleanedSwitch.IsToggled = bool.Parse(App.currentVehicle.Clean);
                        DeepCleanSwitch.IsToggled = bool.Parse(App.currentVehicle.DeepClean);
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
                vehicle.Registration = RegNoEntry.Text;
                if (int.TryParse(StartMileageEntry.Text, out int startMileage))
                {
                    vehicle.StartMileage = startMileage;
                }
                if (int.TryParse(EndMileageEntry.Text, out int endMileage))
                {
                    vehicle.EndMileage = endMileage;
                }
                vehicle.Lights = LightsSwitch.IsToggled.ToString();
                vehicle.Signals = SignalsSwitch.IsToggled.ToString();
                vehicle.Sirens = SirensSwitch.IsToggled.ToString();
                vehicle.FireExtinguisher = FireExtSwitch.IsToggled.ToString();
                vehicle.WarningTriangle = WarnTriangleSwitch.IsToggled.ToString();
                vehicle.FireBlanket = FireBlanketSwitch.IsToggled.ToString();
                vehicle.Clean = VehicleCleanedSwitch.IsToggled.ToString();
                vehicle.DeepClean = DeepCleanSwitch.IsToggled.ToString();
                vehicle.Fuel = Convert.ToInt32(FuelSlider.Value);
                vehicle.VehicleNotes = VehicleNotesEntry.Text;
                vehicle.ShiftID = App.currentShift.ID;
            }
            return vehicle;
        }

        private async void SaveBtn_Clicked(object sender, EventArgs e)
        {
            Vehicle currentVehicle = CurrentVehicleDetails();
            try
            {
                if (currentVehicle.ID != null)
                {
                    await App.MobileService.GetTable<Vehicle>().UpdateAsync(currentVehicle);
                }
                else
                {
                    await App.MobileService.GetTable<Vehicle>().InsertAsync(currentVehicle);
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.ToString(), "ok");
            }
        }
    }

}
