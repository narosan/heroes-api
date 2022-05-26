using AutoMapper;
using HeroesApi.Dto;
using HeroesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApi.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserViewModel, User>().ReverseMap();
            CreateMap<TokenViewModel, Tokens>().ReverseMap();
            CreateMap<UserViewModel, User>().ReverseMap();
        }
    }
}
