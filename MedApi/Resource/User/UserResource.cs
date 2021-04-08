using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApi.Resource.User
{
    public class UserResource
    {
        public string Fullname { get; set; }
        public string ProfilePhoto { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
