using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public class VehicleRepository : IVehicleRepository
    {
        public IEnumerable<Vehicle> AllVehicles => throw new NotImplementedException();

        public Vehicle GetVehicleById(string VehicleId)
        {
            return AllVehicles.FirstOrDefault(predicate => predicate.Id == VehicleId);
        }
    }
}
