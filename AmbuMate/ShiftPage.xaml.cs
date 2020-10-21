using AmbuMate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AmbuMate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShiftPage : ContentPage
    {
        //stores current user and shift details
        public Staff currentUserNav = new Staff();
        public Shift currentShiftNav = new Shift();

        /*//Initiliases the Shift Page for the first time when the user has not entered any shift details
        public ShiftPage(Staff currentUser)
        {
            currentUserNav = currentUser;
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }
*/
        //Initialises the Shift Page with previously entered user details 
        public ShiftPage(Staff currentUser, Shift currentShift)
        {
            currentUserNav = currentUser;
            currentShiftNav = currentShift;
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

            if (currentShift.AttendantID != 0)
            {
                //pupulating fields with current shift details
                AttendantIDEntry.Text = currentShiftNav.AttendantID.ToString();
                DriverIDEntry.Text = currentShiftNav.DriverID.ToString();
                CrewNoPicker.SelectedItem = currentShiftNav.CrewNumber.ToString();
                ShiftTypePicker.SelectedItem = currentShiftNav.ShiftType;
                ShiftDate.Date = currentShiftNav.ShiftDate;
                ShiftStartTime.Time = currentShiftNav.StartTime;
                ShiftEndTime.Time = currentShiftNav.EndTime;
                ShiftNotes.Text = currentShiftNav.Notes;
            }
            else
            {
                AttendantIDEntry.Text = currentUserNav.ID.ToString();
            }
        }

        //stores entered user details in an instance of the shift class when the user leaves the Shift Page
        protected override bool OnBackButtonPressed()
        {
            Shift currentShift = new Shift();
            if (AttendantIDEntry.Text != null)
            {
                currentShift.AttendantID = int.Parse(AttendantIDEntry.Text);
            }
            if (DriverIDEntry.Text != null)
            {
                currentShift.DriverID = int.Parse(DriverIDEntry.Text);
            }
            if (CrewNoPicker.SelectedItem != null) 
            {
                currentShift.CrewNumber = int.Parse(CrewNoPicker.SelectedItem.ToString());
            }
            if (ShiftTypePicker.SelectedItem != null)
            {
                currentShift.ShiftType = ShiftTypePicker.SelectedItem.ToString();
            }
            currentShift.ShiftDate = ShiftDate.Date;
            currentShift.StartTime = ShiftStartTime.Time;
            currentShift.EndTime = ShiftEndTime.Time;
            currentShift.Notes = ShiftNotes.Text;
            Navigation.PushAsync(new HomePage(currentUserNav, currentShift));
            return true;
        }
    }
}