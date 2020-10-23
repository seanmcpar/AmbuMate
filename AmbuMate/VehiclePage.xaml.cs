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
            NavigationPage.SetHasBackButton(this, true);
        }

        private void FuelSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            FuelLabel.Text = "Fuel:\r\n" + Convert.ToInt32(FuelSlider.Value) + "%";
        }
    }
}