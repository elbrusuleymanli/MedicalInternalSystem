using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApi.Data.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool SoftDelete { get; set; }
        public DateTime CreatAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
