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
        [Required]
        [Display(Name="Contratante")]
        public int ContratanteId { get; set; }
        public virtual Contratante Contratante { get; set; }

        [Required]
        public string Cargo { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        [Display(Name = "Valor por Hora")]
        public string ValorHora { get; set; }



    }
}
