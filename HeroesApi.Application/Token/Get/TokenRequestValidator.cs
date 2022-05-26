using FluentValidation;
using HeroesApi.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApi.Application.Token.Get
{
    public class TokenRequestValidator : AbstractValidator<TokenRequest>
    {
        public TokenRequestValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty()
                .WithMessage("Nome não pode ser vazio.");

            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("Password não pode ser vazio.");

            RuleFor(x => x.Password)
                .MaximumLength(8)
                .WithMessage("Password não pode ter mais de 8 dígitos.");
        }
    }
}
