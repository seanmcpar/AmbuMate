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
    public partial class OptionsPage : ContentPage
    {
        public OptionsPage()
        {
            var assembly = typeof(OptionsPage);
            InitializeComponent();
            SyncBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.syncbutton.png", assembly);
            LogOutBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.logoutbutton.png", assembly);
            CancelShiftBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.cancelshiftbutton.png", assembly);
            NavigationPage.SetHasBackButton(this, true);
        }

        private void LogOutBtn_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage( new MainPage());
        }

        private async void CancelShiftBtn_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Cancel Shift", "Would you like to cancel your current shift?", "Yes", "No");
            if (answer)
            {
                Shift shift = App.currentShift;
                shift.ShiftStatus = "Cancelled";
                Shift.Update(shift);
                App.currentShift = null;
                App.currentVehicle = null;
                App.currentKit = null;
            }
        }
    }
}