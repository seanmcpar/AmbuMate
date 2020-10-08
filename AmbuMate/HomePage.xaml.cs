﻿using AmbuMate.Entities;
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
    public partial class HomePage : ContentPage
    {
        public HomePage(staff currentUser)
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
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