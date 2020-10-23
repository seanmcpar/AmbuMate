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
    public partial class KitPage : ContentPage
    {
        public KitPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);
        }

        private void O2Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            O2Label.Text = "O2:\r\n" + Convert.ToInt32(O2Slider.Value) + "%";
        }

        private void N202Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            N2O2Label.Text ="N2O2:\r\n" + Convert.ToInt32(N202Slider.Value) + "%";
        }
    }
}