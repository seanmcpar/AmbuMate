using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public class KitRepository : IKitRepository
    {
        public IEnumerable<Kit> AllKits => throw new NotImplementedException();

        public Kit GetKitById(string KitId)
        {
            return AllKits.FirstOrDefault(predicate => predicate.Id == KitId);
        }
    }
}
