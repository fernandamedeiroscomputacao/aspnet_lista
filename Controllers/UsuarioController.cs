using Microsoft.AspNetCore.Mvc;
using Curso_ASP.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace Curso_ASP.Controllers
{
    public class UsuarioController : Controller
    {

        public IActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario); 

        }

        [HttpPost]
        public IActionResult Usuario(Usuario usuario)
        {
            if (string.IsNullOrEmpty(usuario.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatório"); 
            }

            if (usuario.Senha != usuario.ConfirmarSenha) 
            {
                ModelState.AddModelError("", "Senhas não conferem");
            }

            if(ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario); 
        }

        public IActionResult Resultado(Usuario usuario)
        {
            return View(usuario); 
        }       
        
        public IActionResult LoginUnico(string login)
        {
            var bdExemplo  = new Collection<string>{
                "Joana",
                "Maria", 
                "José"
            };

            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()));
            //return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()),/*JsonRequestBehavior.AllowGet*/);  

        }
    }

}