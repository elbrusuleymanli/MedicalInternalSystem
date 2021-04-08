using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApi.Data.Entities
{
    public class Doctor:BaseEntity
    {
        public string Note { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int ReceptionId { get; set; }
        public Reception Reception { get; set; }
    }
}
