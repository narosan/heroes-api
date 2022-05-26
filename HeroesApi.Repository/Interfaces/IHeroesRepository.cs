using HeroesApi.Models;
using System.Collections.Generic;

namespace HeroesApi.Repository
{
    public interface IHeroesRepository
    {
        ICollection<Heroe> GetAll();
    }
}