using AmbuMate.Entities;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using SQLite;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;
using System.Transactions;

namespace AmbuMate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShiftPage : ContentPage
    {
        public Shift shiftData;

        //Initialises the Shift Page with previously entered user details 
        public ShiftPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            shiftData = App.currentShift;
            if (shiftData.AttendantID == App.currentUser.ID && shiftData.ShiftStatus.Equals("Complete") == false)
            {
                AttendantIDEntry.Text = shiftData.AttendantID.ToString();
                if (shiftData.DriverID != 0) { DriverIDEntry.Text = shiftData.DriverID.ToString(); }
                CrewNoPicker.SelectedItem = shiftData.Crew.ToString();
                ShiftTypePicker.SelectedItem = shiftData.ShiftType;
                ShiftDate.Date = shiftData.ShiftDate;
                ShiftStartTime.Time = shiftData.StartTime.TimeOfDay;
                ShiftEndTime.Time = shiftData.EndTime.TimeOfDay;
                ShiftNotes.Text = shiftData.Notes;
            }
            else
            {
                AttendantIDEntry.Text = App.currentUser.ID.ToString();
            }
        }

        protected override bool OnBackButtonPressed()
        {
            App.currentShift = CurrentShiftDetails();
            Navigation.PushAsync(new HomePage());
            return true;
        }

        private async void SaveBtn_Clicked(object sender, EventArgs e)
        {
            Shift currentShift = CurrentShiftDetails();
            try
            {
                App.currentShift = currentShift;
                if (currentShift.ID != null)
                {
                    await App.MobileService.GetTable<Shift>().UpdateAsync(currentShift);
                }
                else
                {
                    await App.MobileService.GetTable<Shift>().InsertAsync(currentShift);
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", ex.ToString(), "ok");
            }
        }
        private Shift CurrentShiftDetails()
        {
            Shift shift = new Shift();
            {
                if (App.currentShift.ID != null) { shift.ID = App.currentShift.ID; }
                if (int.TryParse(AttendantIDEntry.Text, out int AttendantID))
                {
                    shift.AttendantID = AttendantID;
                }
                if (int.TryParse(DriverIDEntry.Text, out int DriverID))
                {
                    shift.DriverID = DriverID;
                }
                if (CrewNoPicker.SelectedItem != null)
                {
                    shift.Crew = int.Parse(CrewNoPicker.SelectedItem.ToString());
                }
                if (ShiftTypePicker.SelectedItem != null)
                {
                    shift.ShiftType = ShiftTypePicker.SelectedItem.ToString();
                }
                shift.ShiftStatus = "Active";
                shift.ShiftDate = ShiftDate.Date;
                shift.StartTime = DateTime.Parse(ShiftStartTime.Time.ToString());
                shift.EndTime = DateTime.Parse(ShiftEndTime.Time.ToString());
                shift.Notes = ShiftNotes.Text;
            }
            return shift;
        }
    }
}