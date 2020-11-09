using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmbuMate.Entities
{
    public class Shift
    {
        [PrimaryKey, AutoIncrement]
        public string ID { get; set; }
        public int AttendantID { get; set; }
        public int DriverID { get; set; }
        public int Crew { get; set; }
        public string ShiftType { get; set; }
        public string ShiftStatus { get; set; }
        public DateTime ShiftDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }

        public static async void Insert(Shift shift)
        {
            await App.MobileService.GetTable<Shift>().InsertAsync(shift);
        }
        public static async void Update(Shift shift)
        {
            await App.MobileService.GetTable<Shift>().UpdateAsync(shift);
        }

    }

}
