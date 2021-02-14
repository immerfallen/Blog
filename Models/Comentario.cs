using System;


namespace Blog.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        
        public string Autor { get; set; }
        
        public string Conteudo { get; set; }
        
        public DateTime Data { get; set; }
        public int PostId {get;set;} // aqui se dará a chave estrangeira sempre do tipo <nome da classe>Id -- essa propriedade é amarrada com o ICollection<nome da classe>
        
        public Post Post { get; set; }
        
    }
}