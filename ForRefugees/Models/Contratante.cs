using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForRefugees.Models
{
    public class Contratante
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }

        [Required]
        public string Seguimento { get; set; }

        [Required]
        [Display(Name = "Valor Por Hora")]
        public string ValorHora { get; set; }

        [Required]
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public string Senha { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Bio { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string Bairro { get; set; }

        [Required]
        public string Cidade { get; set; }

        [Required]
        public string Estado { get; set; }

        public virtual List<Vaga> Vaga { get; set; }


    }
}
