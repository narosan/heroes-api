using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApi.Application.Heroes.Get
{
    public class HeroesRequestValidator : AbstractValidator<HeroesRequest>
    {
        public HeroesRequestValidator()
        {

        }
    }
}
