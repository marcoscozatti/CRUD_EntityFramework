using EntityFramework_Pesquisa.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_Pesquisa
{
	public partial class frmCadCli : Form
	{
		public frmCadCli()
		{
			InitializeComponent();
		}

		private void frmCadCli_Load(object sender, EventArgs e)
		{
			limpacampos();
			desabilitacampos();
			Atualizadg();

		}

		public void limpacampos()
		{
			//limpa campos
			txtID.Text = "";
			txtNome.Text = "";
			txtSobrenome.Text = "";
			txtRG.Text = "";
			txtCPF.Text = "";
			txtEndereco.Text = "";
			txtEndereco.Text = "";
			txtCidade.Text = "";

		}

		public void desabilitacampos()
		{
			//desabilita campos
			txtID.Enabled = false;
			txtNome.Enabled = false;
			txtSobrenome.Enabled = false; ;
			txtRG.Enabled = false;
			txtCPF.Enabled = false;
			txtEndereco.Enabled = false;
			txtCidade.Enabled = false;
			btnAtualizar.Enabled = false;
			btnSalvar.Enabled = false;
			btnExcluir.Enabled = false;

		}

		public void habilitaacampos()
		{
			//desabilita campos
			txtNome.Enabled = true;
			txtNome.Focus();
			txtSobrenome.Enabled = true;
			txtRG.Enabled = true;
			txtCPF.Enabled = true;
			txtEndereco.Enabled = true;
			txtCidade.Enabled = true;
			btnAtualizar.Enabled = true;
			btnSalvar.Enabled = true;
			btnExcluir.Enabled = true;
		}

		private void btnManutencao_Click(object sender, EventArgs e)
		{
			desabilitacampos();
			habilitaacampos();
			limpacampos();

		}

		private void btnPesquisa_Click(object sender, EventArgs e)
		{
			habilitaacampos();
			txtNome.Enabled = true;
			txtNome.Focus();
			limpacampos();
			Atualizadg();
		}
			
		private void btnSalvar_Click(object sender, EventArgs e)
		{

			using (var tb = new Controle())
			{
				try
				{

					tb.ObjetoCadCli.Add(new CadCli
					{
						Nome = txtNome.Text,
						Sobrenome = txtSobrenome.Text,
						RG = double.Parse(txtRG.Text),
						CPF = double.Parse(txtCPF.Text),
						Endereco = txtEndereco.Text,
						Cidade = txtCidade.Text
					});
					tb.SaveChanges();
					limpacampos();
					desabilitacampos();
					MessageBox.Show("Resgistrado!", "Manutenção da tabela");
					Atualizadg();
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}

			}
		}



		public void Atualizadg()
		{
			using (var tb = new Controle())
			{
				dg.DataSource = null;
				dg.DataSource = tb.ObjetoCadCli.ToList();
			}
		}

		private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			habilitaacampos();
			txtID.Text = dg.CurrentRow.Cells[0].Value.ToString();
			txtNome.Text = dg.CurrentRow.Cells[1].Value.ToString();
			txtSobrenome.Text = dg.CurrentRow.Cells[2].Value.ToString();
			txtRG.Text = dg.CurrentRow.Cells[3].Value.ToString();
			txtCPF.Text = dg.CurrentRow.Cells[4].Value.ToString();
			txtEndereco.Text = dg.CurrentRow.Cells[5].Value.ToString();
			txtCidade.Text = dg.CurrentRow.Cells[6].Value.ToString();
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			using (var tb = new Controle())
			{
				try
				{
					var objeto = tb.ObjetoCadCli.Find(Convert.ToInt32(txtID.Text));
					tb.ObjetoCadCli.Remove(objeto);
					tb.SaveChanges();
					MessageBox.Show("Exlcuido com sucesso", "Exclusão");
					limpacampos();
					desabilitacampos();
					Atualizadg();

				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}

			}
		}

		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			using (var tb = new Controle())
			{
				try
				{
					habilitaacampos();
					var objeto = tb.ObjetoCadCli.Find(Convert.ToInt32(txtID.Text));
					objeto.Nome = txtNome.Text;
					objeto.Sobrenome = txtSobrenome.Text;
					objeto.RG = double.Parse(txtRG.Text);
					objeto.CPF = double.Parse(txtCPF.Text);
					objeto.Endereco = txtEndereco.Text;
					objeto.Cidade = txtCidade.Text;

					tb.SaveChanges();
					MessageBox.Show("Alteração realizada com sucesso", "Alteração");
					limpacampos();
					desabilitacampos();
					Atualizadg();
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message);
				}

			}
		}

		private void txtNome_TextChanged(object sender, EventArgs e)
		{

			if (txtNome.Text== "" && txtID.Text=="")
			{
				Atualizadg();
			}
			try
			{

				using (var tb = new Controle())
				{
				    var resultado = tb.ObjetoCadCli.Where(y => y.Nome == txtNome.Text);

					dg.DataSource = null;
					dg.DataSource = resultado.ToList();
				}

				//using (var tb = new Controle())
				//{
				//	dg.DataSource = null;
				//	dg.DataSource = tb.ObjetoCadCli.ToList();
				//}

			}
			catch (Exception ex)
			{

				MessageBox.Show("Erro: " + ex.Message);
			}
		}
	}
}
