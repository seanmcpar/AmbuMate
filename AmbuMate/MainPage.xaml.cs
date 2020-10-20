using AmbuMate.Entities;
using AmbuMate.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AmbuMate
{
    public partial class MainPage : ContentPage
    {
        public Staff currentUser = new Staff();

        public MainPage()
        {
            InitializeComponent();
            var assembly = typeof(MainPage);
            iconImage.Source = ImageSource.FromResource("AmbuMate.Assets.Images.ambumatelogo.png", assembly);
            
        }

        private async void LogInBtn_Clicked(object sender, EventArgs e)
        {
            if (idEntry.Text != null && passwordEntry.Text != null)
            {
                if (int.TryParse(idEntry.Text.Trim(), out int id))
                {
                    try { 
                    //reads the azure sql database and fetches any staff members matching the ID entered by the user
                    var user = (await App.MobileService.GetTable<Staff>().Where(s => s.ID == id).ToListAsync()).FirstOrDefault();

                        if (user != null)
                        {
                            Password password = new Password();
                            if (password.Verify(passwordEntry.Text.Trim(), user.PasswordHash))
                            {
                                //creating an instance of a Staff class with the details of the user who has logged in
                                currentUser.ID = user.ID;
                                currentUser.FirstName = user.FirstName;
                                currentUser.Surname = user.Surname;
                                currentUser.Staff_type = user.Staff_type;
                                currentUser.PasswordHash = user.PasswordHash;
                                App.Current.MainPage = new NavigationPage( new HomePage(currentUser));
                                //await Navigation.PushAsync(new HomePage(currentUser));
                            }
                            else
                            {
                                await DisplayAlert("Access Denied", "Incorrect Log In Details.", "Ok");
                                passwordEntry.Text = "";
                            }
                        }
                        else
                        {
                            await DisplayAlert("Access Denied", "Incorrect Log In Details.", "Ok");
                            passwordEntry.Text = "";
                        }

                    }
                    catch(Exception ex)
                    {
                        await DisplayAlert("Error", ex.ToString(), "Ok");
                    }
                    
                }
                else
                {
                    await DisplayAlert("Access Denied", "Incorrect Log In Details.", "Ok");
                    passwordEntry.Text = "";
                }

            }
            else
            {
                await DisplayAlert("Access Denied", "Please enter valid log in credentials.", "Ok");
            }
        }
      
    }
}
