using HeroesApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeroesApi.Repository
{
    public interface IHeroesRepository
    {
        Task<IEnumerable<Heroe>> GetAll();
    }
}