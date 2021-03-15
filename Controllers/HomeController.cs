using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PetVet.Models;

namespace PetVet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }
         public IActionResult Agendamento()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult Agendamento(ItemServico item)
        {
            Dados.Incluir(item);
            ViewBag.nome = item.nome;
            ViewBag.telefone = item.telefone;
            ViewBag.animal = item.animal;
            ViewBag.data = item.data;
            ViewBag.necessidade = item.necessidade;
            return View("Concluido");
        }
        public IActionResult Listagem()
        {
            List<ItemServico> itens = Dados.Mostrar();
            return View(itens);
        }
    }
}
