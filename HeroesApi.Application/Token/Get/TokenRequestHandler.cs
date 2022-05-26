using AutoMapper;
using HeroesApi.Dto;
using HeroesApi.Repository.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FluentValidation;
using HeroesApi.Application.Exceptions;

namespace HeroesApi.Application.Token.Get
{
    public class TokenRequestHandler : IRequestHandler<TokenRequest, TokenViewModel>
    {
        private readonly IJwtManagerRepository _jwtManagerRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public TokenRequestHandler(IJwtManagerRepository jwtManagerRepository, IUserRepository userRepository, IMapper mapper)
        {
            _jwtManagerRepository = jwtManagerRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<TokenViewModel> Handle(TokenRequest request, CancellationToken cancellationToken)
        {
            // Chamada ao Validator do Mediator
            TokenRequestValidator validator = new();
                
            await validator.ValidateAndThrowAsync(request, cancellationToken);

            // Chamada ao repository de usuário para avaliar se usuário existe.
            if (!_userRepository.Exist(request.Nome, request.Password))
            {
                throw new UserNotFindException();
            }

            // Chamada ao repository de token para geração.
            var token = _jwtManagerRepository.Authenticate(request.Nome, request.Password);
                
            // Mapper de Entidade para estrutura DTO/ViewModel
            return await Task.FromResult(_mapper.Map<TokenViewModel>(token));   
        }
    }
}
