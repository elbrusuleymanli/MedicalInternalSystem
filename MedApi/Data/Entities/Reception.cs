using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApi.Data.Entities
{
    public class Reception:BaseEntity
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
