using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AmbuMate.Entities
{
    public class Kit
    {
        [PrimaryKey, AutoIncrement]
        public string ID { get; set; }
        public string ShiftID { get; set; }
        public string ParaBag { get; set; }
        public string DrugsBag { get; set; }
        public string Zoll { get; set; }
        public string CarryChair { get; set; }
        public string WheelChair { get; set; }
        public string Stretcher { get; set; }
        public string VomitBowl { get; set; }
        public string Wipes { get; set; }
        public string BlueRoll { get; set; }
        public string Sheets { get; set; }
        public string Pillows { get; set; }
        public string Blankets { get; set; }
        public string SPO2 { get; set; }
        public string BPCuff { get; set; }
        public string Thermometer { get; set; }
        public string bandages { get; set; }
        public string Plasters { get; set; }
        public string WoundDressing { get; set; }
        public string Gauze { get; set; }
        public string CleansingWipe { get; set; }
        public string PinsClips { get; set; }
        public string Tape { get; set; }
        public string Tweezers { get; set; }
        public string Scissors { get; set; }
        public string FoilBlanket { get; set; }
        public string Torch { get; set; }
        public string BVMask { get; set; }
        public int O2 { get; set; }
        public int N2O2 { get; set; }
        public string KitUsed { get; set; }
        public string Status { get; set; }
    }
}
