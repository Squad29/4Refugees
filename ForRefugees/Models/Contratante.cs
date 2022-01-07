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
        public string Nome { get; set; }
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Display(Name = "CNPJ")]
        public string Cnpj { get; set; }
        public string Seguimento { get; set; }
        
        [Display(Name = "Valor Por Hora")]
        public string ValorHora { get; set; }
        
        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Bio { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public virtual List<Avaliacao> Avaliacao { get; set; }
        public virtual List<Vaga> Vaga { get; set; }


    }
}
