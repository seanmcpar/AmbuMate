using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmbuControl.Models
{
    public class PatientRepository : IPatientRepository
    {
        public IEnumerable<Patient> AllPatients => throw new NotImplementedException();

        public Patient GetPatientById(string PatientId)
        {
            return AllPatients.FirstOrDefault(predicate => predicate.Id == PatientId);
        }

        public List<Patient> GetPatientByReference(int PatientReference)
        {
            return AllPatients.Where(predicate => predicate.Reference == PatientReference).ToList();
        }
    }
}
