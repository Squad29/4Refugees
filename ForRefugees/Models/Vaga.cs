using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForRefugees.Models
{
    public class Vaga
    {
        [Key]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [ForeignKey("Contratante")]
        [Display(Name="Contratante")]
        public int ContratanteId { get; set; }
        public virtual Contratante Contratante { get; set; }

        public string Cargo { get; set; }
        public string Descricao { get; set; }
        public string ValorHora { get; set; }



    }
}
