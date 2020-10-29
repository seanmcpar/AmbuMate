
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmbuMate.Entities
{
    public class Vehicle
    {
        [PrimaryKey, AutoIncrement]
        public string ID { get; set; }
        public string RegNumber { get; set; }
        public string ShiftID { get; set; }
        public int StartMileage { get; set; }
        public bool Lights { get; set; }
        public bool Signals { get; set; }
        public bool Sirens { get; set; }
        public bool FireExtinguisher { get; set; }
        public bool WarningTriangle { get; set; }
        public bool FireBlanket { get; set; }
        public bool Clean { get; set; }
        public bool DeepClean { get; set; }
        public int Fuel { get; set; }
        public int EndMileage { get; set; }
        public string VehicleNotes { get; set; }

    }
}
