using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForRefugees.Models

{
	public class Refugiado
    {
		[Key]
		public int Id { get; set; }
		public string Nome { get; set; }

		[Display(Name = "CPF")]
		public string Cpf { get; set; }
		public string Cidade { get; set; }
		public string Telefone { get; set; }
		public string Estado { get; set; }

		[Display(Name = "Profissão")]
		public string Profissao { get; set; }
		public string Nacionalidade { get; set; }
		public string Bio { get; set; }
		
		[Display(Name = "Data de Nascimento")]
		public DateTime DataNascimento { get; set; }

		[Display(Name = "Data de Cadastro")]
		public DateTime DataCadastro { get; set; } = DateTime.Now;

		[Display(Name = "Valor por Hora")]
		public string ValorHora { get; set; }
		[Display(Name = "Endereço")]
		public string Endereco { get; set; }
		public string Bairro { get; set; }

		public virtual List<Avaliacao> Avaliacao { get; set; }
	}
}
