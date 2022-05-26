using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using HeroesApi.Models;

namespace HeroesApi.Core
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HeroesContext(serviceProvider.GetService<DbContextOptions<HeroesContext>>()))
            {
                AddHeroesData(context);
                AddUserData(context);
            }
        }

        private static void AddHeroesData(HeroesContext context)
        {
            if (context.Heroes.Any()) { return; }

            var heroes = new List<Heroe>()
                {
                    new Heroe { Nome = "Superman", DataNascimento = DateTime.Now, Cidade = "Smallvile"},
                    new Heroe { Nome = "Batman", DataNascimento = DateTime.Now, Cidade = "Gotham" }
                };

            context.AddRange(heroes);
            context.SaveChanges();
        }

        private static void AddUserData(HeroesContext context)
        {
            if (context.Users.Any()) { return; }

            var users = new List<User>()
                {
                    new User { Nome = "mat", Password = "1234" },
                    new User { Nome = "duda", Password = "1234" }
                };

            context.AddRange(users);
            context.SaveChanges();
        }

    }
}
