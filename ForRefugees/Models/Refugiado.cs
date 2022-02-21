using System;
using System.ComponentModel.DataAnnotations;

namespace ForRefugees.Models

{
    public class Refugiado
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]

        [Display(Name = "CPF")]
        public string Cpf { get; set; }
        [Required]

        public string Cidade { get; set; }
        [Required]

        public string Telefone { get; set; }
        
        [Required]
        public string Estado { get; set; }

        [Display(Name = "Profissão")]
        [Required]
        public string Profissao { get; set; }
        
        [Required]
        public string Nacionalidade { get; set; }

        [Required]
        [MaxLength(150, ErrorMessage = "Limite de Caracteres excedido")]
        public string Bio { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Display(Name = "Data de Nascimento")]
        [Required]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "Valor por Hora")]
        public string ValorHora { get; set; }
        
        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
       
        [Required]
        public string Bairro { get; set; }

    }
}
