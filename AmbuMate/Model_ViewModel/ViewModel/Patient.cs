using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace AmbuMate.Entities
{
    public class Patient //: INotifyPropertyChanged
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value;
                //OnPropertyChanged("Id");
                    }
        }

        private int reference;

        public int Reference
        {
            get { return reference; }
            set { reference = value;
                //OnPropertyChanged("Reference");
            }
        }

        private string shiftID;

        public string ShiftID
        {
            get { return shiftID; }
            set { shiftID = value;
                //OnPropertyChanged("ShiftID");
            }
        }
         
        private string status;

        public string Status
        {
            get { return status; }
            set { status = value;
                //OnPropertyChanged("Status");
            }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value;
                //OnPropertyChanged("FirstName");
            }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value;
                //OnPropertyChanged("Surname");
            }
        }

        private string pickup;

        public string PickUp
        {
            get { return pickup; }
            set { pickup = value;
                //OnPropertyChanged("PickUp");
            }
        }

        private string dropoff;

        public string DropOff
        {
            get { return dropoff; }
            set { dropoff = value;
                //OnPropertyChanged("DropOff");
            }
        }

        private string specialrequirements;

        public string SpecialRequirements
        {
            get { return specialrequirements; }
            set { specialrequirements = value;
                //OnPropertyChanged("SpecialRequirements");
            }
        }

        private string infectious;

        public string Infectious
        {
            get { return infectious; }
            set { infectious = value;
                //OnPropertyChanged("Infectious");
            }
        }

        private DateTime arrivepickup;

        public DateTime ArrivePickUp
        {
            get { return arrivepickup; }
            set { arrivepickup = value;
                //OnPropertyChanged("ArrivePickUp");
            }
        }

        private DateTime departpickup;

        public DateTime DepartPickUp
        {
            get { return departpickup; }
            set { departpickup = value;
                //OnPropertyChanged("DepartPickUp");
            }
        }

        private DateTime arrivedropoff;

        public DateTime ArriveDropOff
        {
            get { return arrivedropoff; }
            set { arrivedropoff = value;
                //OnPropertyChanged("ArriveDropOff");
            }
        }
        
        private DateTime departDropOff;

        public DateTime DepartDropOff
        {
            get { return departDropOff; }
            set { departDropOff = value;
                //OnPropertyChanged("DepartDropOff");
            }
        }
        
        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value;
                //OnPropertyChanged("Notes");
            }
        }


       //public event PropertyChangedEventHandler PropertyChanged;

        public static async void Insert(Patient patient)
        {
            await App.MobileService.GetTable<Patient>().InsertAsync(patient);
        }

        public static async void Update(Patient patient)
        {
            await App.MobileService.GetTable<Patient>().UpdateAsync(patient);
        }

        public static async Task<List<Patient>> ReadInactivePatients() 
        {
            var patients = await App.MobileService.GetTable<Patient>().Where(p => p.ShiftID == App.currentShift.Id && p.Status == "Inactive").ToListAsync();
            return patients;
        }

        public static async Task<List<Patient>> ReadActivePatients()
        {
            var patients = await App.MobileService.GetTable<Patient>().Where(p => p.ShiftID == App.currentShift.Id && p.Status == "Active").ToListAsync();
            return patients;
        }

        public static async Task<List<Patient>> ReadCompletePatients()
        {
            var patients = await App.MobileService.GetTable<Patient>().Where(p => p.ShiftID == App.currentShift.Id && p.Status == "Complete").ToListAsync();
            return patients;
        }

       /* private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }*/
    }
}
