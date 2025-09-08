using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pokedex.Models;

namespace Pokedex.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Regiao> Regioes { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonTipo> PokemonTipos  { get; set;}
    }
}