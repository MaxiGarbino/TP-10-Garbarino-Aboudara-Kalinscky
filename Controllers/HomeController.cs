using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_10_Garbarino_Aboudara_Kalinscky.Models;

namespace TP_10_Garbarino_Aboudara_Kalinscky.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.listarSeries();
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public List<Actores> VerDetalleActoresAjax(int IdSerie){
        List<Actores> actores = BD.listarActores(IdSerie);
        return actores;
    }
    public List<Temporadas> VerDetalleTemporadaAjax(int IdSerie){
        List<Temporadas> temporadas = BD.listarTemporadas(IdSerie);
        return temporadas;
    }
    public Series VerDetalleSerieAjax(int IdSerie){
        Series serie = BD.DetalleSerie(IdSerie);
        return serie;
    }
}
