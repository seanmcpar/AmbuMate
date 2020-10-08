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
            NavigationPage.SetHasBackButton(this, true);
        }
    }
}