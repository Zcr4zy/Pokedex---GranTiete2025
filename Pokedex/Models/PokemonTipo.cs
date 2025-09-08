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
        [Required(ErrorMessage = "Informe o pokemon!")]
        public int PokemonId { get; set; }
        [ForeignKey("PokemonId")]
        public Pokemon Pokemon { get; set; }

        [Required(ErrorMessage = "Informe o tipo do pokemon!")]
        public int TipoId { get; set; }
        [ForeignKey("TipoId")]
        public Tipo Tipo { get; set; }
    }
}