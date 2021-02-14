using System.Collections.Generic;
using System.Linq;

namespace Blog.Models
{
    public class PostService
    {
        public int CreatePost(Post novoPost)
        {
            using (var context = new BlogContext())
            {
                context.Add(novoPost);
                context.SaveChanges();
                return novoPost.Id;
            }
        }
        public ICollection<Post> GetPosts()
        {
            using(var context = new BlogContext())
            {
                ICollection<Post> resultado = context.Posts.ToList();
                return resultado;
            }
        }
    }
}