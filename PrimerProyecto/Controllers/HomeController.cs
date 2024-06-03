using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerProyecto.Models;

namespace PrimerProyecto.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Paquete = OrtWorld.DicPaquetes;
        return View();
    }

    public IActionResult SelectPaquete()
    {
        ViewBag.Hotel = OrtWorld.ListaHoteles;
        ViewBag.Aereo = OrtWorld.ListaAereos;
        ViewBag.Excursion =OrtWorld.ListaExcursiones;
        ViewBag.Destino = OrtWorld.ListaDestinos;
        return View();
    }
     
    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
       Paquete paqueteNuevo = new Paquete ( OrtWorld.ListaHoteles(Hotel),OrtWorld.ListaAereos(Aereo), OrtWorld.ListaExcursiones(Excursion), OrtWorld.ListaDestinos(Destino));

       return View();
    }
}
