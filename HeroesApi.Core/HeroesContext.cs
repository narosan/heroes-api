using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesApi.Models;

namespace HeroesApi.Core
{
    public class HeroesContext : DbContext
    {
        public HeroesContext(DbContextOptions<HeroesContext> options) : base(options)
        {

        }

        public DbSet<Heroe> Heroes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
