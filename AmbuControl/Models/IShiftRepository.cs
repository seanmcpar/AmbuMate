using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public interface IShiftRepository
    {

        IEnumerable<Shift> AllShifts { get; }
        Shift GetShiftById(string ShiftfId);
    }
}
