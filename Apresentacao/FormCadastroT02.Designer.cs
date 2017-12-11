namespace Apresentacao
{
	partial class FormCadastroT02
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
			if(disposing && (components != null))
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
            this.labelTabela = new System.Windows.Forms.Label();
            this.labelCampoTabela = new System.Windows.Forms.Label();
            this.labelNomeCampo = new System.Windows.Forms.Label();
            this.labelOrdem = new System.Windows.Forms.Label();
            this.labelValorPadrao = new System.Windows.Forms.Label();
            this.labelTipoCampo = new System.Windows.Forms.Label();
            this.labelOperador = new System.Windows.Forms.Label();
            this.textBoxTabela = new System.Windows.Forms.TextBox();
            this.textBoxCampoTabela = new System.Windows.Forms.TextBox();
            this.textBoxNomeCampo = new System.Windows.Forms.TextBox();
            this.textBoxOrdemCampo = new System.Windows.Forms.TextBox();
            this.comboBoxOperador = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoCampo = new System.Windows.Forms.ComboBox();
            this.textBoxValorPadrao = new System.Windows.Forms.TextBox();
            this.panelControles.SuspendLayout();
            this.panelNavegacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNovo
            // 
            this.toolTipFormBase.SetToolTip(this.buttonNovo, "Adicionar Registro!");
            // 
            // buttonRelatorio
            // 
            this.toolTipFormBase.SetToolTip(this.buttonRelatorio, "Abrir Relatórios!");
            // 
            // buttonProximo
            // 
            this.toolTipFormBase.SetToolTip(this.buttonProximo, "Próximo Registro!");
            // 
            // buttonPesquisa
            // 
            this.toolTipFormBase.SetToolTip(this.buttonPesquisa, "Abrir Pesquisa!");
            // 
            // buttonUltimo
            // 
            this.toolTipFormBase.SetToolTip(this.buttonUltimo, "Ultimo Registro!");
            // 
            // buttonPrimeiro
            // 
            this.toolTipFormBase.SetToolTip(this.buttonPrimeiro, "Primeiro Registro!");
            // 
            // buttonAnterior
            // 
            this.toolTipFormBase.SetToolTip(this.buttonAnterior, "Registro Anterior!");
            // 
            // buttonSair
            // 
            this.toolTipFormBase.SetToolTip(this.buttonSair, "Sair da Tela!");
            // 
            // buttonDesfazer
            // 
            this.toolTipFormBase.SetToolTip(this.buttonDesfazer, "Desfazer Alterações!");
            // 
            // buttonExcluir
            // 
            this.toolTipFormBase.SetToolTip(this.buttonExcluir, "Excluir Registro!");
            // 
            // buttonEditar
            // 
            this.toolTipFormBase.SetToolTip(this.buttonEditar, "Editar Registro!");
            // 
            // buttonSalvar
            // 
            this.toolTipFormBase.SetToolTip(this.buttonSalvar, "Gravar Registro!");
            // 
            // labelTabela
            // 
            this.labelTabela.AutoSize = true;
            this.labelTabela.Location = new System.Drawing.Point(38, 107);
            this.labelTabela.Name = "labelTabela";
            this.labelTabela.Size = new System.Drawing.Size(43, 13);
            this.labelTabela.TabIndex = 3;
            this.labelTabela.Text = "Tabela:";
            // 
            // labelCampoTabela
            // 
            this.labelCampoTabela.AutoSize = true;
            this.labelCampoTabela.Location = new System.Drawing.Point(38, 135);
            this.labelCampoTabela.Name = "labelCampoTabela";
            this.labelCampoTabela.Size = new System.Drawing.Size(43, 13);
            this.labelCampoTabela.TabIndex = 4;
            this.labelCampoTabela.Text = "Campo:";
            // 
            // labelNomeCampo
            // 
            this.labelNomeCampo.AutoSize = true;
            this.labelNomeCampo.Location = new System.Drawing.Point(7, 219);
            this.labelNomeCampo.Name = "labelNomeCampo";
            this.labelNomeCampo.Size = new System.Drawing.Size(74, 13);
            this.labelNomeCampo.TabIndex = 5;
            this.labelNomeCampo.Text = "Nome Campo:";
            // 
            // labelOrdem
            // 
            this.labelOrdem.AutoSize = true;
            this.labelOrdem.Location = new System.Drawing.Point(40, 247);
            this.labelOrdem.Name = "labelOrdem";
            this.labelOrdem.Size = new System.Drawing.Size(41, 13);
            this.labelOrdem.TabIndex = 6;
            this.labelOrdem.Text = "Ordem:";
            // 
            // labelValorPadrao
            // 
            this.labelValorPadrao.AutoSize = true;
            this.labelValorPadrao.Location = new System.Drawing.Point(10, 273);
            this.labelValorPadrao.Name = "labelValorPadrao";
            this.labelValorPadrao.Size = new System.Drawing.Size(71, 13);
            this.labelValorPadrao.TabIndex = 7;
            this.labelValorPadrao.Text = "Valor Padrão:";
            // 
            // labelTipoCampo
            // 
            this.labelTipoCampo.AutoSize = true;
            this.labelTipoCampo.Location = new System.Drawing.Point(-1, 190);
            this.labelTipoCampo.Name = "labelTipoCampo";
            this.labelTipoCampo.Size = new System.Drawing.Size(82, 13);
            this.labelTipoCampo.TabIndex = 8;
            this.labelTipoCampo.Text = "Tipo do Campo:";
            // 
            // labelOperador
            // 
            this.labelOperador.AutoSize = true;
            this.labelOperador.Location = new System.Drawing.Point(27, 163);
            this.labelOperador.Name = "labelOperador";
            this.labelOperador.Size = new System.Drawing.Size(54, 13);
            this.labelOperador.TabIndex = 9;
            this.labelOperador.Text = "Operador:";
            // 
            // textBoxTabela
            // 
            this.textBoxTabela.Enabled = false;
            this.textBoxTabela.Location = new System.Drawing.Point(81, 103);
            this.textBoxTabela.Name = "textBoxTabela";
            this.textBoxTabela.Size = new System.Drawing.Size(268, 20);
            this.textBoxTabela.TabIndex = 10;
            // 
            // textBoxCampoTabela
            // 
            this.textBoxCampoTabela.Enabled = false;
            this.textBoxCampoTabela.Location = new System.Drawing.Point(81, 131);
            this.textBoxCampoTabela.Name = "textBoxCampoTabela";
            this.textBoxCampoTabela.Size = new System.Drawing.Size(268, 20);
            this.textBoxCampoTabela.TabIndex = 11;
            // 
            // textBoxNomeCampo
            // 
            this.textBoxNomeCampo.Enabled = false;
            this.textBoxNomeCampo.Location = new System.Drawing.Point(81, 215);
            this.textBoxNomeCampo.Name = "textBoxNomeCampo";
            this.textBoxNomeCampo.Size = new System.Drawing.Size(268, 20);
            this.textBoxNomeCampo.TabIndex = 12;
            // 
            // textBoxOrdemCampo
            // 
            this.textBoxOrdemCampo.Enabled = false;
            this.textBoxOrdemCampo.Location = new System.Drawing.Point(81, 243);
            this.textBoxOrdemCampo.Name = "textBoxOrdemCampo";
            this.textBoxOrdemCampo.Size = new System.Drawing.Size(268, 20);
            this.textBoxOrdemCampo.TabIndex = 13;
            // 
            // comboBoxOperador
            // 
            this.comboBoxOperador.Enabled = false;
            this.comboBoxOperador.FormattingEnabled = true;
            this.comboBoxOperador.Location = new System.Drawing.Point(81, 159);
            this.comboBoxOperador.Name = "comboBoxOperador";
            this.comboBoxOperador.Size = new System.Drawing.Size(268, 21);
            this.comboBoxOperador.TabIndex = 14;
            // 
            // comboBoxTipoCampo
            // 
            this.comboBoxTipoCampo.Enabled = false;
            this.comboBoxTipoCampo.FormattingEnabled = true;
            this.comboBoxTipoCampo.Location = new System.Drawing.Point(81, 186);
            this.comboBoxTipoCampo.Name = "comboBoxTipoCampo";
            this.comboBoxTipoCampo.Size = new System.Drawing.Size(268, 21);
            this.comboBoxTipoCampo.TabIndex = 15;
            // 
            // textBoxValorPadrao
            // 
            this.textBoxValorPadrao.Enabled = false;
            this.textBoxValorPadrao.Location = new System.Drawing.Point(81, 269);
            this.textBoxValorPadrao.Name = "textBoxValorPadrao";
            this.textBoxValorPadrao.Size = new System.Drawing.Size(268, 20);
            this.textBoxValorPadrao.TabIndex = 16;
            // 
            // FormCadastroT02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(579, 313);
            this.Controls.Add(this.textBoxValorPadrao);
            this.Controls.Add(this.comboBoxTipoCampo);
            this.Controls.Add(this.comboBoxOperador);
            this.Controls.Add(this.textBoxOrdemCampo);
            this.Controls.Add(this.textBoxNomeCampo);
            this.Controls.Add(this.textBoxCampoTabela);
            this.Controls.Add(this.textBoxTabela);
            this.Controls.Add(this.labelOperador);
            this.Controls.Add(this.labelTipoCampo);
            this.Controls.Add(this.labelValorPadrao);
            this.Controls.Add(this.labelOrdem);
            this.Controls.Add(this.labelNomeCampo);
            this.Controls.Add(this.labelCampoTabela);
            this.Controls.Add(this.labelTabela);
            this.Name = "FormCadastroT02";
            this.Text = "T02 - Campos da Pesquisa";
            this.Controls.SetChildIndex(this.panelControles, 0);
            this.Controls.SetChildIndex(this.panelNavegacao, 0);
            this.Controls.SetChildIndex(this.textBoxControles, 0);
            this.Controls.SetChildIndex(this.labelTabela, 0);
            this.Controls.SetChildIndex(this.labelCampoTabela, 0);
            this.Controls.SetChildIndex(this.labelNomeCampo, 0);
            this.Controls.SetChildIndex(this.labelOrdem, 0);
            this.Controls.SetChildIndex(this.labelValorPadrao, 0);
            this.Controls.SetChildIndex(this.labelTipoCampo, 0);
            this.Controls.SetChildIndex(this.labelOperador, 0);
            this.Controls.SetChildIndex(this.textBoxTabela, 0);
            this.Controls.SetChildIndex(this.textBoxCampoTabela, 0);
            this.Controls.SetChildIndex(this.textBoxNomeCampo, 0);
            this.Controls.SetChildIndex(this.textBoxOrdemCampo, 0);
            this.Controls.SetChildIndex(this.comboBoxOperador, 0);
            this.Controls.SetChildIndex(this.comboBoxTipoCampo, 0);
            this.Controls.SetChildIndex(this.textBoxValorPadrao, 0);
            this.panelControles.ResumeLayout(false);
            this.panelNavegacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Label labelTabela;
        private System.Windows.Forms.Label labelCampoTabela;
        private System.Windows.Forms.Label labelNomeCampo;
        private System.Windows.Forms.Label labelOrdem;
        private System.Windows.Forms.Label labelValorPadrao;
        private System.Windows.Forms.Label labelTipoCampo;
        private System.Windows.Forms.Label labelOperador;
        private System.Windows.Forms.TextBox textBoxTabela;
        private System.Windows.Forms.TextBox textBoxCampoTabela;
        private System.Windows.Forms.TextBox textBoxNomeCampo;
        private System.Windows.Forms.TextBox textBoxOrdemCampo;
        private System.Windows.Forms.ComboBox comboBoxOperador;
        private System.Windows.Forms.ComboBox comboBoxTipoCampo;
        private System.Windows.Forms.TextBox textBoxValorPadrao;
    }
}
