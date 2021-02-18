﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public interface IStaffRepository
    {
        IEnumerable<Staff> AllStaff { get; }
        Staff GetStaffById(int StaffId);
    }
}