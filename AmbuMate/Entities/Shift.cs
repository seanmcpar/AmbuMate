using System;
using System.Collections.Generic;
using System.Text;

namespace AmbuMate.Entities
{
    public class Shift
    {
        public int AttendantID { get; set; }
        public int DriverID { get; set; }
        public int CrewNumber { get; set; }
        public string ShiftType { get; set; }
        public string ShiftStatus { get; set; }
        public DateTime ShiftDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Notes { get; set; }
    }
}
