using HeroesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApi.Repository.Interfaces
{
    public interface IJwtManagerRepository
    {
        Tokens Authenticate(string nome, string password);
    }
}
