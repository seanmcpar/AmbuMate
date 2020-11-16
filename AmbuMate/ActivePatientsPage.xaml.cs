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
    public partial class ActivePatientsPage : ContentPage
    {
        ViewCell lastCell;

        public ActivePatientsPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var activePatients = await Patient.ReadActivePatients();
            ActivePatientsListview.ItemsSource = activePatients;
        }


       

        private async void ViewCell_Tapped(object sender, EventArgs e)
        {

            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.FromHex("DDDDDD");
                lastCell = viewCell;
            }
            await Navigation.PushAsync(new ActivePatientFormPage(ActivePatientsListview.SelectedItem as Patient));
        }
    }
}