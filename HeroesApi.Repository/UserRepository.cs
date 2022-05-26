using HeroesApi.Core;
using HeroesApi.Models;
using HeroesApi.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HeroesApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly HeroesContext _context;
        public UserRepository(HeroesContext context)
        {
            _context = context;
        }

        public User GetUser(User user)
        {
            return _context.Users.Where(u => u.Nome.Equals(user.Nome) && u.Password.Equals(user.Password)).FirstOrDefault();
        }

        public bool Exist(string nome, string password)
        {
            return _context.Users.Any(u => u.Nome.Equals(nome) && u.Password.Equals(password));
        }
    }
}
