namespace EntityFramework_Pesquisa
{
	partial class frmCadCli
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblID = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblSobrenome = new System.Windows.Forms.Label();
			this.lblRG = new System.Windows.Forms.Label();
			this.lblCPF = new System.Windows.Forms.Label();
			this.lblEndereco = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtSobrenome = new System.Windows.Forms.TextBox();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.dg = new System.Windows.Forms.DataGridView();
			this.btnPesquisa = new System.Windows.Forms.Button();
			this.btnManutencao = new System.Windows.Forms.Button();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.lblCidade = new System.Windows.Forms.Label();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.SuspendLayout();
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.Location = new System.Drawing.Point(25, 21);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(21, 17);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "ID";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(25, 58);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(45, 17);
			this.lblNome.TabIndex = 0;
			this.lblNome.Text = "Nome";
			// 
			// lblSobrenome
			// 
			this.lblSobrenome.AutoSize = true;
			this.lblSobrenome.Location = new System.Drawing.Point(25, 101);
			this.lblSobrenome.Name = "lblSobrenome";
			this.lblSobrenome.Size = new System.Drawing.Size(81, 17);
			this.lblSobrenome.TabIndex = 0;
			this.lblSobrenome.Text = "Sobrenome";
			// 
			// lblRG
			// 
			this.lblRG.AutoSize = true;
			this.lblRG.Location = new System.Drawing.Point(25, 139);
			this.lblRG.Name = "lblRG";
			this.lblRG.Size = new System.Drawing.Size(29, 17);
			this.lblRG.TabIndex = 0;
			this.lblRG.Text = "RG";
			// 
			// lblCPF
			// 
			this.lblCPF.AutoSize = true;
			this.lblCPF.Location = new System.Drawing.Point(25, 180);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(34, 17);
			this.lblCPF.TabIndex = 0;
			this.lblCPF.Text = "CPF";
			// 
			// lblEndereco
			// 
			this.lblEndereco.AutoSize = true;
			this.lblEndereco.Location = new System.Drawing.Point(25, 221);
			this.lblEndereco.Name = "lblEndereco";
			this.lblEndereco.Size = new System.Drawing.Size(69, 17);
			this.lblEndereco.TabIndex = 0;
			this.lblEndereco.Text = "Endereço";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(113, 21);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(303, 22);
			this.txtID.TabIndex = 12;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(113, 55);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(303, 22);
			this.txtNome.TabIndex = 1;
			this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
			// 
			// txtSobrenome
			// 
			this.txtSobrenome.Location = new System.Drawing.Point(113, 96);
			this.txtSobrenome.Name = "txtSobrenome";
			this.txtSobrenome.Size = new System.Drawing.Size(303, 22);
			this.txtSobrenome.TabIndex = 2;
			// 
			// txtRG
			// 
			this.txtRG.Location = new System.Drawing.Point(113, 136);
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(303, 22);
			this.txtRG.TabIndex = 3;
			// 
			// txtCPF
			// 
			this.txtCPF.Location = new System.Drawing.Point(113, 175);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(303, 22);
			this.txtCPF.TabIndex = 4;
			// 
			// txtEndereco
			// 
			this.txtEndereco.Location = new System.Drawing.Point(113, 216);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(303, 22);
			this.txtEndereco.TabIndex = 5;
			// 
			// dg
			// 
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Location = new System.Drawing.Point(28, 301);
			this.dg.Name = "dg";
			this.dg.RowHeadersWidth = 51;
			this.dg.RowTemplate.Height = 24;
			this.dg.Size = new System.Drawing.Size(551, 221);
			this.dg.TabIndex = 13;
			this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
			// 
			// btnPesquisa
			// 
			this.btnPesquisa.Location = new System.Drawing.Point(438, 21);
			this.btnPesquisa.Name = "btnPesquisa";
			this.btnPesquisa.Size = new System.Drawing.Size(108, 23);
			this.btnPesquisa.TabIndex = 11;
			this.btnPesquisa.Text = "Pesquisar";
			this.btnPesquisa.UseVisualStyleBackColor = true;
			this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
			// 
			// btnManutencao
			// 
			this.btnManutencao.Location = new System.Drawing.Point(438, 58);
			this.btnManutencao.Name = "btnManutencao";
			this.btnManutencao.Size = new System.Drawing.Size(108, 23);
			this.btnManutencao.TabIndex = 7;
			this.btnManutencao.Text = "Manutenção";
			this.btnManutencao.UseVisualStyleBackColor = true;
			this.btnManutencao.Click += new System.EventHandler(this.btnManutencao_Click);
			// 
			// btnExcluir
			// 
			this.btnExcluir.Location = new System.Drawing.Point(438, 174);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(108, 23);
			this.btnExcluir.TabIndex = 10;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.UseVisualStyleBackColor = true;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Location = new System.Drawing.Point(25, 263);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(52, 17);
			this.lblCidade.TabIndex = 0;
			this.lblCidade.Text = "Cidade";
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(113, 258);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(303, 22);
			this.txtCidade.TabIndex = 6;
			// 
			// btnSalvar
			// 
			this.btnSalvar.Location = new System.Drawing.Point(438, 96);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(108, 23);
			this.btnSalvar.TabIndex = 8;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = true;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.Location = new System.Drawing.Point(438, 136);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(108, 23);
			this.btnAtualizar.TabIndex = 9;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// frmCadCli
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(601, 534);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.btnExcluir);
			this.Controls.Add(this.btnSalvar);
			this.Controls.Add(this.btnManutencao);
			this.Controls.Add(this.btnPesquisa);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.txtRG);
			this.Controls.Add(this.txtSobrenome);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblCidade);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lblEndereco);
			this.Controls.Add(this.lblCPF);
			this.Controls.Add(this.lblRG);
			this.Controls.Add(this.lblSobrenome);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblID);
			this.Name = "frmCadCli";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de Clientes";
			this.Load += new System.EventHandler(this.frmCadCli_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblSobrenome;
		private System.Windows.Forms.Label lblRG;
		private System.Windows.Forms.Label lblCPF;
		private System.Windows.Forms.Label lblEndereco;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtSobrenome;
		private System.Windows.Forms.TextBox txtRG;
		private System.Windows.Forms.TextBox txtCPF;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.DataGridView dg;
		private System.Windows.Forms.Button btnPesquisa;
		private System.Windows.Forms.Button btnManutencao;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnAtualizar;
	}
}

