using AmbuMate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmbuMate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PatientFormPage : ContentPage
    {
        
        public PatientFormPage()
        {
            InitializeComponent();
            var assembly = typeof(PatientFormPage);
            addPatientBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.addpatient.png", assembly);
        }

        private void addPatientBtn_Clicked(object sender, EventArgs e)
        {
            try
            {
                Patient patient = PatientDetails();
                Patient.Insert(patient);
                Navigation.PopAsync();
            }
            catch
            {
                DisplayAlert("Error", "Saving Patient Details Failed", "Ok");
            }
        }

        private Patient PatientDetails()
        {
            Patient patient = new Patient()
            {
                Reference = int.Parse(PatientReferenceEntry.Text),
                ShiftID = App.currentShift.ID,
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