using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmbuMate.Entities
{
    public class Patient
    {
        [PrimaryKey, AutoIncrement]
        public string ID { get; set; }
        public int PatientReference { get; set; }
        //[ForeignKey(typeof(Shift))]
        public string ShiftID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PickUp {get;set;}
        public string DropOff { get; set; }
        public string SpecialRequirements { get; set; }
        public bool Infectious { get; set; }
        public TimeSpan ArrivePickup { get; set; }
        public TimeSpan DepartPickup { get; set; }
        public TimeSpan ArriveDropoff { get; set; }
        public TimeSpan DepartDropoff { get; set; }
        public string Notes { get; set; }
        //[ManyToOne]
        //public Shift Shift { get; set; }

    }
}
