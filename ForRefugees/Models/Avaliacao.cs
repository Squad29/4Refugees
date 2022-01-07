using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForRefugees.Models
{
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; }
        public int Positivo { get; set; }
        public int Negativo { get; set; }
        public DateTime dataAvaliacao { get; set; } = DateTime.Now;

        [ForeignKey("Contratante")]
        public int ContratanteId { get; set; }
        public virtual Contratante Contratante { get; set; }

        [ForeignKey("Refugiado")]
        public int RefugiadoId { get; set; }
        public virtual Refugiado Refugiado { get; set; }
        
    }
}
