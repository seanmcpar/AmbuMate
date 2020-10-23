using System;
using System.Collections.Generic;
using System.Text;

namespace AmbuMate.Entities
{
    class Vehicle
    {
        public string RegNumber { get; set; }
        public int Mileage { get; set; }
        public bool Lights { get; set; }
        public bool Signals { get; set; }
        public bool Sirens { get; set; }
        public bool FireExtinguisher { get; set; }
        public bool WarningTriangle { get; set; }
        public bool FireBlanket { get; set; }
        public bool Clean { get; set; }
        public bool DeepClean { get; set; }

    }
}
