﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> AllVehicles { get; }
        Vehicle GetVehicleById(string VehicleId);
    }
}