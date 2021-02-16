using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public class StaffRepository : IStaffRepository
    {
        public IEnumerable<Staff> AllStaff => throw new NotImplementedException();

        public Staff GetStaffById(int StaffId)
        {
            return AllStaff.FirstOrDefault(predicate => predicate.ID == StaffId);
        }
    }
}
