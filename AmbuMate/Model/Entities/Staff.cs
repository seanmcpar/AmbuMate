using AmbuMate.Logic;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace AmbuMate.Entities
{
    public class Staff : INotifyPropertyChanged
    {
        private int id;

        public int Id
        {
            get { return id; }
            set 
            { 
                id = value;
                OnPropertyChanged("Id");
            }
            
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set 
            { 
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set 
            { 
                surname = value;
                OnPropertyChanged("Surname");
            }
        }

        private string staff_type;

        public string Staff_type
        {
            get { return staff_type; }
            set 
            { 
                staff_type = value;
                OnPropertyChanged("Staff_type");
            }
        }

        private string passwordHash;

        public string PasswordHash
        {
            get { return passwordHash; }
            set 
            { 
                passwordHash = value;
                OnPropertyChanged("PasswordHash");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public static async Task<bool> LogIn(string id, string password)
        {
            bool isIdEmpty = string.IsNullOrEmpty(id);
            bool isPasswordEmpty = string.IsNullOrEmpty(password);

            if (isIdEmpty || isPasswordEmpty)
            {
                return false;
            }
            else
            {
                if (int.TryParse(id.Trim(), out int loginID))
                {
                    //reads the azure sql database and fetches any staff members matching the ID entered by the user
                    var user = (await App.MobileService.GetTable<Staff>().Where(s => s.Id == loginID).ToListAsync()).FirstOrDefault();
                    
                    if (user != null)
                    {
                            PasswordCheck passwordcheck = new PasswordCheck();
                            if (passwordcheck.Verify(password.Trim(), user.PasswordHash))
                            {
                                App.currentUser = user;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                     }
                     else
                     {
                            return false;
                     }

                }
                else
                {
                    return false;
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
