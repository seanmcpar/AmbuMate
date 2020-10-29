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
        public bool ParaBag { get; set; }
        public bool DrugsBag { get; set; }
        public bool Zoll { get; set; }
        public bool VomitBowl { get; set; }
        public bool Wipes { get; set; }
        public bool BlueRoll { get; set; }
        public bool Sheets { get; set; }
        public bool Pillows { get; set; }
        public bool Blankets { get; set; }
        public bool SPO2 { get; set; }
        public bool BPCuff { get; set; }
        public bool Thermo { get; set; }
        public bool Plasters { get; set; }
        public bool WoundDressing { get; set; }
        public bool Gauze { get; set; }
        public bool CleansingWipes { get; set; }
        public bool PinsClips { get; set; }
        public bool Tape { get; set; }
        public bool Tweezers { get; set; }
        public bool Scissors { get; set; }
        public bool FoilBlanket { get; set; }
        public bool Torch { get; set; }
        public bool BVMask { get; set; }
        public int O2 { get; set; }
        public int N2O2 { get; set; }
        public string KitUsed { get; set; }
        //[OneToOne]
        //public Vehicle Vehicle { get; set; }
    }
}
