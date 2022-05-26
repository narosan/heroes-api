using HeroesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApi.Repository.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(User user);
        bool Exist(string nome, string password);
    }
}
