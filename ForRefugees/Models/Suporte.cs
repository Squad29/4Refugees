using System.ComponentModel.DataAnnotations;

namespace ForRefugees.Models

{
    public class Suporte
    {
        [Key]
        public int id { get; set; }
        public string mensagem { get; set; }
        public string assunto { get; set; }
        public string email { get; set; }
        public string nome { get; set; }
    }
}
