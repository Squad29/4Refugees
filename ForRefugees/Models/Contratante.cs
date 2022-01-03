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
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Seguimento { get; set; }
        public string ValorHora { get; set; }
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

    }
}
