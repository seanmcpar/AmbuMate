using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmbuMate.Entities
{
    public class Staff
    {
        [PrimaryKey]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Staff_type { get; set; }
        public string PasswordHash { get; set; }
    }
}
