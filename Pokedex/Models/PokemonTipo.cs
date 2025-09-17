using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    [Table("PokemonTipo")]
    public class PokemonTipo
    {
        public int PokemonNumero { get; set; }
        [ForeignKey("PokemonNumero")]
        public Pokemon Pokemon { get; set; }

        [Required(ErrorMessage = "Informe o tipo do pokemon!")]
        public int TipoId { get; set; }
        [ForeignKey("TipoId")]
        public Tipo Tipo { get; set; }
    }
}