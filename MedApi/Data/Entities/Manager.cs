using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApi.Data.Entities
{
    public class Manager:BaseEntity
    {
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public Reception Reception { get; set; }
        public int ReceptionId { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
