using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public interface IKitRepository
    {
        IEnumerable<Kit> AllKits { get; }
        Kit GetKitById(string KitId);
    }
}
