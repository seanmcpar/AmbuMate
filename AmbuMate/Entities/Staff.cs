using System;
using System.Collections.Generic;
using System.Text;

namespace AmbuMate.Entities
{
    public class Staff
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Staff_type { get; set; }
        public string PasswordHash { get; set; }
    }
}
