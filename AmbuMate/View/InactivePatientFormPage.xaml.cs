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
    public partial class InactivePatientFormPage : ContentPage
    {
        Patient currentPatient;
        public InactivePatientFormPage(Patient patient)
        {
            currentPatient = patient;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            PatientReferenceEntry.Text = currentPatient.Reference.ToString();
            FirstNameEntry.Text = currentPatient.FirstName;
            SurnameEntry.Text = currentPatient.Surname;
            PickupLocationEditor.Text = currentPatient.PickUp;
            DropoffLocationEditor.Text = currentPatient.DropOff;
            if (currentPatient.SpecialRequirements != null)
            {
                SpecialRequirementsEditor.Text = currentPatient.SpecialRequirements;
            }
            else
            {
                SpecialRequirementsEditor.Text = "N/A";
            }
            InfectiousSwitch.IsToggled = bool.Parse(currentPatient.Infectious);

        }

        private void ActivatePatientButton_Clicked(object sender, EventArgs e)
        {
                currentPatient = PatientDetails();
                currentPatient.Status = "Active";
                Patient.Update(currentPatient);
                Navigation.PopAsync();
        }

        private Patient PatientDetails()
        {
            Patient patient = new Patient()
            {
                Id = currentPatient.Id,
                Reference = int.Parse(PatientReferenceEntry.Text),
                ShiftID = App.currentShift.Id,
                Status = "Inactive",
                FirstName = FirstNameEntry.Text,
                Surname = SurnameEntry.Text,
                PickUp = PickupLocationEditor.Text,
                DropOff = DropoffLocationEditor.Text,
                SpecialRequirements = SpecialRequirementsEditor.Text,
                Infectious = InfectiousSwitch.IsToggled.ToString()

            };
            return patient;
        }

        private async void CancelPatientButton_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Cancel Shift", "Would you like to cancel this patient?", "Yes", "No");
            if (answer)
            {
                currentPatient = PatientDetails();
                currentPatient.Status = "Cancelled";
                Patient.Update(currentPatient);
                await Navigation.PopAsync();
            }
        }
    }
}