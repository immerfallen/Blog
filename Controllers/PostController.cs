using Microsoft.AspNetCore.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
         public IActionResult Cadastro(Post novoPost)
        {
            PostService service = new PostService();
            int novoId = service.CreatePost(novoPost);
            if(novoId != 0)
            {
                ViewData["Mensagem"] = "Post criado com sucesso!";
            }
            else
            {
                ViewData["Mensagem"] = "Falha no cadastro!";
            }
            return View();
        }

        public IActionResult Lista()
        {
            PostService service = new PostService();
            return View(service.GetPosts());
        }
    }

}