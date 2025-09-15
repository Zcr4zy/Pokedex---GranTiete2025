using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    [Table("Pokemon")]
    public class Pokemon
    {
        [Key]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Informe a região do pokemon!")]
        public int RegiaoId { get; set; }
        [ForeignKey("RegiaoId")]
        public Regiao Regiao { get; set; }

        [Required(ErrorMessage = "Informe o gênero do pokemon!")]
        public int GeneroId { get; set; }
        [ForeignKey("GeneroId")]
        public Genero Genero { get; set; }

        [StringLength(30)]
        [Required(ErrorMessage = "Informe o nome do tipo do pokemon!")]
        public string Nome { get; set; }

        [StringLength(1000)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Informe a altura do pokemon!")]
        [Column(TypeName = "double(5,2)")]
        public decimal Altura { get; set; } = 0;

        [Required(ErrorMessage = "Informe o peso do pokemon!")]
        [Column(TypeName = "double(7,3)")]
        public decimal Peso { get; set; } = 0;

        [StringLength(200)]
        public string Imagem { get; set; }

        [StringLength(400)]
        public string Animacao { get; set; }

        public List<PokemonTipo> Tipos { get; set; }

    }
}