using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Pesquisa.Entidade
{

	class CadCli
	{
		[Key]
		public int IdUsuario { get; set; }
		public string Nome { get; set; }
		public string Sobrenome { get; set; }
		public Double RG { get; set; }
		public Double CPF { get; set; }
		public string Endereco { get; set; }
		public string Cidade  { get; set; }
	}

}
