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
    }
}