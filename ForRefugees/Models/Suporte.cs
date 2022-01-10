using System.ComponentModel.DataAnnotations;

namespace ForRefugees.Models

{
    public class Suporte
    {
        [Key]
        public int id { get; set; }

        [Display(Name ="Mensagem")]
        [Required(ErrorMessage ="Favor preencher o campo acima")]
        public string mensagem { get; set; }
        [Display(Name ="Assunto")]
        [Required(ErrorMessage = "Favor preencher o campo acima")]
        public string assunto { get; set; }
        [Display(Name ="Email")]
        [Required(ErrorMessage = "Favor preencher o campo acima")]
        public string email { get; set; }
        [Display(Name ="Nome")]
        [Required(ErrorMessage = "Favor preencher o campo acima")]
        public string nome { get; set; }
    }
}
