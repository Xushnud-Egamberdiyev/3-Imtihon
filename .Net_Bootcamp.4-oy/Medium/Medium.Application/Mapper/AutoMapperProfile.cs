using AutoMapper;
using Medium.Domain.Entity.DTOs;
using Medium.Domain.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
