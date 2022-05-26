using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesApi.Models
{
    public class Heroe
    {
        public Heroe()
        {

        }

        [Key]
        public long Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Cidade { get; set; }
    }
}
