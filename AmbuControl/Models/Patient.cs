using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public class Patient
    {
        public string Id { get; set; }
        public int Reference { get; set; }
        public string ShiftID { get; set; }
        public string Status { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PickUp { get; set; }
        public string DropOff { get; set; }
        public string SpecialRequirements { get; set; }
        public string Infectious { get; set; }
        public DateTime ArrivePickUp { get; set; }
        public DateTime DepartPickUp { get; set; }
        public DateTime ArriveDropOff { get; set; }
        public DateTime DepartDropOff { get; set; }
        public string Notes { get; set; }
    }
}
