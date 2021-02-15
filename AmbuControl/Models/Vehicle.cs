using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public class Vehicle
    {
        public string Id { get; set; }
        public string Registration { get; set; }
        public string ShiftID { get; set; }
        public int StartMileage { get; set; }
        public string Lights { get; set; }
        public string Signals { get; set; }
        public string Sirens { get; set; }
        public string FireExtinguisher { get; set; }
        public string WarningTriangle { get; set; }
        public string FireBlanket { get; set; }
        public string Clean { get; set; }
        public string DeepClean { get; set; }
        public int Fuel { get; set; }
        public int EndMileage { get; set; }
        public string Status { get; set; }
        public string VehicleNotes { get; set; }
    }
}
