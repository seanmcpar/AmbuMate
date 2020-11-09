using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AmbuMate.Entities
{
    public class Patient
    {
        [PrimaryKey, AutoIncrement]
        public string ID { get; set; }
        public int Reference { get; set; }
        public string ShiftID { get; set; }
        public string Status { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PickUp { get; set; }
        public string DropOff { get; set; }
        public string SpecialRequirements { get; set; }
        public string Infectious { get; set; }
        public DateTime ArrivePickup { get; set; }
        public DateTime DepartPickup { get; set; }
        public DateTime ArriveDropoff { get; set; }
        public DateTime DepartDropoff { get; set; }
        public string Notes { get; set; }

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
            var patients = await App.MobileService.GetTable<Patient>().Where(p => p.ShiftID == App.currentShift.ID && p.Status == "Inactive").ToListAsync();
            return patients;
        }
    }
}
