using AmbuMate.Entities;
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
    public partial class ActivePatientFormPage : ContentPage
    {
        Patient currentPatient;
        public ActivePatientFormPage(Patient patient)
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
                Infectious = InfectiousSwitch.IsToggled.ToString(),
                ArrivePickUp = DateTime.Parse(ArrivePickUp.Time.ToString()),
                DepartPickUp = DateTime.Parse(DepartPickUp.Time.ToString()),
                ArriveDropOff = DateTime.Parse(ArriveDropOff.Time.ToString()),
                DepartDropOff = DateTime.Parse(DepartDropOff.Time.ToString()),
                Notes = NotesEditor.Text
            };
            return patient;

        }

        private void setInactiveBtn_Clicked(object sender, EventArgs e)
        {
            currentPatient = PatientDetails();
            currentPatient.Status = "Inactive";
            Patient.Update(currentPatient);
            Navigation.PopAsync();
        }

        private void completePatientBtn_Clicked(object sender, EventArgs e)
        {
            currentPatient = PatientDetails();
            currentPatient.Status = "Complete";
            Patient.Update(currentPatient);
            Navigation.PopAsync();
        }

        private void CancelPatientButton_Clicked(object sender, EventArgs e)
        {
            currentPatient = PatientDetails();
            currentPatient.Status = "Cancelled";
            Patient.Update(currentPatient);
            Navigation.PopAsync();
        }
    }
}