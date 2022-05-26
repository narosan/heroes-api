using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApi.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Password { get; set; }
    }
}
