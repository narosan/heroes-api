using AutoMapper;
using HeroesApi.Dto;
using HeroesApi.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;

namespace HeroesApi.Application.Heroes.Get
{
    public class HeroesRequestHandler : IRequestHandler<HeroesRequest, IEnumerable<HeroeViewModel>>
    {
        private readonly IHeroesRepository _heroesRepository;
        private readonly IMapper _mapper;

        public HeroesRequestHandler(IHeroesRepository heroesRepository, IMapper mapper)
        {
            _heroesRepository = heroesRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<HeroeViewModel>> Handle(HeroesRequest request, CancellationToken cancellationToken)
        {
            HeroesRequestValidator validator = new();
            await validator.ValidateAndThrowAsync(request, cancellationToken);

            var heroes = await _heroesRepository.GetAll();
            return _mapper.Map<IEnumerable<HeroeViewModel>>(heroes);
        }
    }
}
