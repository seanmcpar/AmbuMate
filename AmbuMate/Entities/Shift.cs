using System;
using System.Collections.Generic;
using System.Text;

namespace AmbuMate.Entities
{
    public class Shift
    {
        public int AttendantID { get; set; }
        public int DriverID { get; set; }
        public object ShiftType { get; set; }
        public DateTime ShiftDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Notes { get; set; }
    }
}
