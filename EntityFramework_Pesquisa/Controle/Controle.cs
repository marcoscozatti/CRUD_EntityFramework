using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Pesquisa.Entidade
{
	class Controle : DbContext
	{
		public Controle() : base(@"Server=.\SQLEXPRESS; Database=BDCadCli; Integrated Security=true;")
		{

		}
		public DbSet<CadCli> ObjetoCadCli { get; set; }

	}
}


//	  * 1-) enable-migrations

//	  * 2-) Add-migration banco

//	  * 3-) update-database
