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
    public partial class KitPage : ContentPage
    {
        Kit kitData;
        public KitPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            kitData = App.currentKit;
            RegNumberEntry.Text = App.currentVehicle.Registration;

            if (kitData != null && kitData.Status == "Active")
            {
                ParaBagSwitch.IsToggled = bool.Parse(kitData.ParaBag);
                DrugsBagSwitch.IsToggled = bool.Parse(kitData.DrugsBag);
                ZollSwitch.IsToggled = bool.Parse(kitData.Zoll);
                CarryChairSwitch.IsToggled = bool.Parse(kitData.CarryChair);
                WheelChairSwitch.IsToggled = bool.Parse(kitData.Wheelchair);
                StretcherSwitch.IsToggled= bool.Parse(kitData.Stretcher);
                VomitBowlSwitch.IsToggled = bool.Parse(kitData.VomitBowl);
                WipesSwitch.IsToggled = bool.Parse(kitData.Wipes);
                BlueRollSwitch.IsToggled = bool.Parse(kitData.BlueRoll);
                SheetsSwitch.IsToggled = bool.Parse(kitData.Sheets);
                PillowsSwitch.IsToggled = bool.Parse(kitData.Pillows);
                BlanketsSwitch.IsToggled = bool.Parse(kitData.Blankets);
                Spo2Switch.IsToggled = bool.Parse(kitData.SPO2);
                BPCuffSwitch.IsToggled = bool.Parse(kitData.BPCuff);
                ThermoSwitch.IsToggled = bool.Parse(kitData.Thermometer);
                BandagesSwitch.IsToggled = bool.Parse(kitData.Bandages);
                PlastersSwitch.IsToggled = bool.Parse(kitData.Plasters);
                WoundDressSwitch.IsToggled = bool.Parse(kitData.WoundDressing);
                GauzeSwitch.IsToggled = bool.Parse(kitData.Gauze);
                CleansingWipesSwitch.IsToggled = bool.Parse(kitData.CleansingWipe);
                PinsClipsSwitch.IsToggled = bool.Parse(kitData.PinsClips);
                TapeSwitch.IsToggled = bool.Parse(kitData.Tape);
                TweezersSwitch.IsToggled = bool.Parse(kitData.Tweezers);
                ScissorsSwitch.IsToggled = bool.Parse(kitData.Scissors);
                FoilBlanketSwitch.IsToggled = bool.Parse(kitData.FoilBlanket);
                TorchSwitch.IsToggled = bool.Parse(kitData.Torch);
                BVMaskSwitch.IsToggled = bool.Parse(kitData.BVMask);
                if (kitData.KitUsed != null) { KitUsedEditor.Text = kitData.KitUsed; }
                if (kitData.O2 != 0) { O2Slider.Value = kitData.O2; }
                if (kitData.N2O2 != 0) { N202Slider.Value = kitData.N2O2; }
            }
        }

        protected override void OnDisappearing()
        {
            App.currentKit = CurrentKitDetails();
            base.OnDisappearing();
        }

        protected override bool OnBackButtonPressed()
        {
            App.currentKit = CurrentKitDetails();
            Navigation.PopAsync();
            return true;
        }

        private void O2Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            O2Label.Text = "O2:\r\n" + Convert.ToInt32(O2Slider.Value) + "%";
        }

        private void N202Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            N2O2Label.Text ="N2O2:\r\n" + Convert.ToInt32(N202Slider.Value) + "%";
        }


        private void SaveBtn_Clicked(object sender, EventArgs e)
        {
            Kit currentKit = CurrentKitDetails();
            try
            {
                App.currentKit = currentKit;
                if (currentKit.Id != null)
                {
                    Kit.Update(currentKit);
                    DisplayAlert("Success", "Kit Details Updated.", "Ok");
                }
                else
                {
                    Kit.Insert(currentKit);
                    DisplayAlert("Success", "Kit Details Saved.", "Ok");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "Kit details failed to save.", "ok");
            }
        }

        private Kit CurrentKitDetails()
        {
            Kit kit = new Kit();
            {
                if (App.currentKit != null) { kit.Id = App.currentKit.Id; }
                kit.ShiftID = App.currentShift.Id;
                kit.Status = "Active";
                kit.ParaBag = ParaBagSwitch.IsToggled.ToString();
                kit.DrugsBag = DrugsBagSwitch.IsToggled.ToString();
                kit.Zoll = ZollSwitch.IsToggled.ToString();
                kit.CarryChair = CarryChairSwitch.IsToggled.ToString();
                kit.Wheelchair = WheelChairSwitch.IsToggled.ToString();
                kit.Stretcher = StretcherSwitch.IsToggled.ToString();
                kit.VomitBowl = VomitBowlSwitch.IsToggled.ToString();
                kit.Wipes = WipesSwitch.IsToggled.ToString();
                kit.BlueRoll = BlueRollSwitch.IsToggled.ToString();
                kit.Sheets = SheetsSwitch.IsToggled.ToString();
                kit.Pillows = PillowsSwitch.IsToggled.ToString();
                kit.Blankets = BlanketsSwitch.IsToggled.ToString();
                kit.SPO2 = Spo2Switch.IsToggled.ToString();
                kit.BPCuff = BPCuffSwitch.IsToggled.ToString();
                kit.Thermometer = ThermoSwitch.IsToggled.ToString();
                kit.Bandages = BandagesSwitch.IsToggled.ToString();
                kit.Plasters = PlastersSwitch.IsToggled.ToString();
                kit.WoundDressing = WoundDressSwitch.IsToggled.ToString();
                kit.Gauze = GauzeSwitch.IsToggled.ToString();
                kit.CleansingWipe = CleansingWipesSwitch.IsToggled.ToString();
                kit.PinsClips = PinsClipsSwitch.IsToggled.ToString();
                kit.Tape = TapeSwitch.IsToggled.ToString();
                kit.Tweezers = TweezersSwitch.IsToggled.ToString();
                kit.Scissors = ScissorsSwitch.IsToggled.ToString();
                kit.FoilBlanket = FoilBlanketSwitch.IsToggled.ToString();
                kit.Torch = TorchSwitch.IsToggled.ToString();
                kit.BVMask = BVMaskSwitch.IsToggled.ToString();
                kit.O2 = Convert.ToInt32(O2Slider.Value);
                kit.N2O2 = Convert.ToInt32(N202Slider.Value);
                kit.KitUsed = KitUsedEditor.Text;
            }

            return kit;
        }

        private async void CompleteBtn_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Complete Kit", "Would you like to complete the kit form?", "Yes", "No");
            if (answer)
            {
                kitData = CurrentKitDetails();
                kitData.Status = "Complete";
                Kit.Update(kitData);
                await Navigation.PopAsync();
            }
        }
    }
}