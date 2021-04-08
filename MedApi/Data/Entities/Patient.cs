using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApi.Data.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
        public bool IsMarried { get; set; }
        public DateTime RegisterDate { get; set; }
        public string PassportNo { get; set; }
        public DateTime PasspExpDate { get; set; }
        public DateTime Birdhday { get; set; }
        public string SickPurpose { get; set; }

    }
}
