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
    public partial class InactivePatientsPage : ContentPage
    {
        ViewCell lastCell;

        public InactivePatientsPage()
        {
            InitializeComponent();
        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var inactivePatients = await Patient.ReadInactivePatients();
            InactivePatientsListview.ItemsSource = inactivePatients;
        }

        private void ViewCell_Tapped(object sender, EventArgs e)
        {
            if (lastCell != null)
                lastCell.View.BackgroundColor = Color.Transparent;
            var viewCell = (ViewCell)sender;
            if (viewCell.View != null)
            {
                viewCell.View.BackgroundColor = Color.FromHex("DDDDDD");
                lastCell = viewCell;
            }
        }

        private void InactivePatientsListview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = InactivePatientsListview.SelectedItem as Patient;
            Navigation.PushAsync(new InactivePatientFormPage(selectedItem));
        }
    }
}