using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.Controllers
{
    public class ComentarioController : Controller
    {
        public IActionResult Cadastrar(Comentario c)
        {
            ComentarioService service = new ComentarioService();
            c.Data = DateTime.Now;
            int novoId = service.CreateComentario(c);                               
            return RedirectToAction("Index","Home");
        }
            
        
    }
}
