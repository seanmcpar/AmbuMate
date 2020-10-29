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
    public partial class PatientFormPage : ContentPage
    {
        
        public PatientFormPage()
        {
            InitializeComponent();
            var assembly = typeof(PatientFormPage);
            addPatientBtn.Source = ImageSource.FromResource("AmbuMate.Assets.Images.addpatient.png", assembly);
        }
    }
}