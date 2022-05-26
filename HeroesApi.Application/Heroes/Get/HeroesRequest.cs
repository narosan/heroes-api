using HeroesApi.Dto;
using MediatR;
using System.Collections.Generic;

namespace HeroesApi.Application.Heroes.Get
{
    public class HeroesRequest : IRequest<IEnumerable<HeroeViewModel>>
    {
    }
}
