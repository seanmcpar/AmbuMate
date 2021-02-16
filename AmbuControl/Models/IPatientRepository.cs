using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public interface IPatientRepository
    {
        IEnumerable<Patient> AllPatients { get; }
        Patient GetPatientById(string PatientId);
        Patient GetPatientByReference(int PatientReference);
    }
}
