using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _aula_06.Models;

namespace _aula_06.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Responder()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Responder(Resposta resposta)
    {
        Repositorio.AdicionarResposta(resposta);
        return Content("Recebemos sua resposta com sucesso.");
    }
}
