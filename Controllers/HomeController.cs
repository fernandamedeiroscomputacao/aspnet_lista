using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Curso_ASP.Models;
using Microsoft.AspNetCore.Http;

namespace Curso_ASP.Controllers
{
    public class HomeController : Controller
    {

     
        public IActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Joao",
                Tipo = "Adm"
            };

            return View(pessoa);
        }

        public IActionResult Contatos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Lista(Pessoa pessoa)
        {
           /* ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo; 
*/
            return View(pessoa);
        }

      /*  private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
    }
}
