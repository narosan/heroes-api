using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesApi.Dto;

namespace HeroesApi.Application.Token
{
    public class TokenRequest : IRequest<TokenViewModel>
    {
        public string Nome { get; set; }
        public string Password { get; set; }
    }
}
