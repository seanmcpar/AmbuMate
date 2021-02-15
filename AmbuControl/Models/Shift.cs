using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public class Shift
    {
        public string Id { get; set; }
        public int AttendantID { get; set; }
        public int DriverID { get; set; }
        public int Crew { get; set; }
        public string ShiftType { get; set; }
        public string ShiftStatus { get; set; }
        public DateTime ShiftDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Notes { get; set; }
    }
}
