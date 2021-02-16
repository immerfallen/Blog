using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class ComentarioService
    {
        public int CreateComentario(Comentario novoComentario)
        {
            using (var context = new BlogContext())
            {
                context.Add(novoComentario);
                context.SaveChanges();
                return novoComentario.Id;
            }
        }

        public ICollection<Comentario> GetComentarios(int idPost)
        {
            using (var context = new BlogContext())
            {
                

                return context.Comentarios.Where(c => c.PostId == idPost).ToList();
            }
        }
    }
}
