using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public class ShiftRepository : IShiftRepository
    {
        public IEnumerable<Shift> AllShifts => throw new NotImplementedException();

        public Shift GetShiftById(string ShiftfId)
        {
            return AllShifts.FirstOrDefault(predicate => predicate.Id == ShiftfId);
        }
    }
}
