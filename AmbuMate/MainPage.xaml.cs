using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AmbuMate
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var assembly = typeof(MainPage);
            iconImage.Source = ImageSource.FromResource("AmbuMate.Assets.Images.ambumatelogo.png", assembly);
        }

        private void LogInBtn_Clicked(object sender, EventArgs e)
        {

        }
    }
}
