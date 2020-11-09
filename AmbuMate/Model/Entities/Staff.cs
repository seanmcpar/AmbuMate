using AmbuMate.Logic;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;

namespace AmbuMate.Entities
{
    public class Staff
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Staff_type { get; set; }
        public string PasswordHash { get; set; }


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
                    var user = (await App.MobileService.GetTable<Staff>().Where(s => s.ID == loginID).ToListAsync()).FirstOrDefault();
                    
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

    }
}
