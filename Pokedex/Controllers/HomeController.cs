using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pokedex.Data;
using Pokedex.Models;
using Pokedex.ViewModels;

namespace Pokedex.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext Db)
    {
        _logger = logger;
        _db = Db;
    }

    public IActionResult Index()
    {
        var pokemons = _db.Pokemons.Include(i => i.Tipos).ThenInclude(i => i.Tipo).ToList();
        return View(pokemons);
    }

    public IActionResult Details(int id)
    {
        var pokemon = _db.Pokemons.Where(f => f.Numero == id).Include(i => i.Genero).Include(i => i.Regiao).Include(i => i.Tipos).ThenInclude(i => i.Tipo).SingleOrDefault();
        DetailsVM details = new()
        {
            Atual = pokemon,
            Anterior = _db.Pokemons.OrderByDescending(o => o.Numero).FirstOrDefault(f => f.Numero < id),
            Proximo = _db.Pokemons.OrderBy(o => o.Numero).FirstOrDefault(f => f.Numero > id)
        };
        return View(details);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
