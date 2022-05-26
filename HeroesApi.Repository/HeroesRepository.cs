using HeroesApi.Core;
using HeroesApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HeroesApi.Repository
{
    public class HeroesRepository : IHeroesRepository
    {
        private readonly HeroesContext _heroesContext;
        public HeroesRepository(HeroesContext heroesContext)
        {
            _heroesContext = heroesContext;
        }
        public async Task<IEnumerable<Heroe>> GetAll()
        {
            return await _heroesContext.Heroes.ToListAsync();
        }
    }
}
