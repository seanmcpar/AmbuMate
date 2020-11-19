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
    public class Staff
    {
        public int ID
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string Surname
        {
            get;
            set;
        }
       
        public string Staff_type
        {
            get;
            set;
        }
        
        public string PasswordHash
        {
            get;
            set;
        }

    }
}
