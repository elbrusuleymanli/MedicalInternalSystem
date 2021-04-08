using AutoMapper;
using MedApi.Data.Entities;
using MedApi.Resource.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedApi.Infrastructures.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            // User
            CreateMap<User, UserResource>();
            CreateMap<UserRegisterResource, User>();
        }
    }
}
