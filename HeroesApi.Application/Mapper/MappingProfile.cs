using AutoMapper;
using HeroesApi.Dto;
using HeroesApi.Models;
using System.Collections.Generic;
namespace HeroesApi.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserViewModel, User>().ReverseMap();
            CreateMap<TokenViewModel, Tokens>().ReverseMap();
            CreateMap<HeroeViewModel, Heroe>().ReverseMap();
        }
    }
}
