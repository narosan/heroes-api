using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApi.Application.Exceptions
{
    public class HeroesException : Exception
    {
    }

    public class UserException : Exception
    {
    }

    public class UserNotFindException : Exception
    {
        public UserNotFindException() 
            : base("Nome de usuário ou senha incorreto.")
        {
        }

        public UserNotFindException(string message) : base(message)
        {
        }

        public UserNotFindException(string message, Exception inner) : base(message, inner)
        {
        }

    }
}
