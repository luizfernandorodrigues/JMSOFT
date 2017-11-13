namespace Apresentacao
{
    partial class FormUsuarioCadastro
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
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelNomeUsuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPortaSmtp = new System.Windows.Forms.Label();
            this.labelUsuarioEmail = new System.Windows.Forms.Label();
            this.labelServidorEmail = new System.Windows.Forms.Label();
            this.labelSenhaEmail = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSenhaEmail = new System.Windows.Forms.TextBox();
            this.textBoxPortaSmtp = new System.Windows.Forms.TextBox();
            this.textBoxServidorEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsuarioEmail = new System.Windows.Forms.TextBox();
            this.groupBoxConfiguracaoEmail = new System.Windows.Forms.GroupBox();
            this.checkBoxSsl = new System.Windows.Forms.CheckBox();
            this.panelControles.SuspendLayout();
            this.panelNavegacao.SuspendLayout();
            this.groupBoxConfiguracaoEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNovo
            // 
            this.toolTipFormBase.SetToolTip(this.buttonNovo, "Adicionar Registro!");
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.TabIndex = 1;
            this.toolTipFormBase.SetToolTip(this.buttonRelatorio, "Abrir Relatórios!");
            // 
            // buttonProximo
            // 
            this.buttonProximo.TabIndex = 5;
            this.toolTipFormBase.SetToolTip(this.buttonProximo, "Próximo Registro!");
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.TabIndex = 0;
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
            this.buttonSair.TabIndex = 4;
            this.toolTipFormBase.SetToolTip(this.buttonSair, "Sair da Tela!");
            // 
            // buttonDesfazer
            // 
            this.buttonDesfazer.TabIndex = 3;
            this.toolTipFormBase.SetToolTip(this.buttonDesfazer, "Desfazer Alterações!");
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.TabIndex = 2;
            this.toolTipFormBase.SetToolTip(this.buttonExcluir, "Excluir Registro!");
            // 
            // buttonEditar
            // 
            this.buttonEditar.TabIndex = 5;
            this.toolTipFormBase.SetToolTip(this.buttonEditar, "Editar Registro!");
            // 
            // panelNavegacao
            // 
            this.panelNavegacao.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.TabIndex = 9;
            // 
            // buttonSalvar
            // 
            this.toolTipFormBase.SetToolTip(this.buttonSalvar, "Gravar Registro!");
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(48, 104);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(46, 13);
            this.labelUsuario.TabIndex = 5;
            this.labelUsuario.Text = "Usuário:";
            // 
            // labelNomeUsuario
            // 
            this.labelNomeUsuario.AutoSize = true;
            this.labelNomeUsuario.Location = new System.Drawing.Point(2, 133);
            this.labelNomeUsuario.Name = "labelNomeUsuario";
            this.labelNomeUsuario.Size = new System.Drawing.Size(92, 13);
            this.labelNomeUsuario.TabIndex = 6;
            this.labelNomeUsuario.Text = "Nome do Usuário:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(53, 161);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(41, 13);
            this.labelSenha.TabIndex = 7;
            this.labelSenha.Text = "Senha:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(56, 16);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelPortaSmtp
            // 
            this.labelPortaSmtp.AutoSize = true;
            this.labelPortaSmtp.Location = new System.Drawing.Point(380, 73);
            this.labelPortaSmtp.Name = "labelPortaSmtp";
            this.labelPortaSmtp.Size = new System.Drawing.Size(68, 13);
            this.labelPortaSmtp.TabIndex = 9;
            this.labelPortaSmtp.Text = "Porta SMTP:";
            // 
            // labelUsuarioEmail
            // 
            this.labelUsuarioEmail.AutoSize = true;
            this.labelUsuarioEmail.Location = new System.Drawing.Point(2, 101);
            this.labelUsuarioEmail.Name = "labelUsuarioEmail";
            this.labelUsuarioEmail.Size = new System.Drawing.Size(92, 13);
            this.labelUsuarioEmail.TabIndex = 8;
            this.labelUsuarioEmail.Text = "Usuário do E-mail:";
            // 
            // labelServidorEmail
            // 
            this.labelServidorEmail.AutoSize = true;
            this.labelServidorEmail.Location = new System.Drawing.Point(12, 73);
            this.labelServidorEmail.Name = "labelServidorEmail";
            this.labelServidorEmail.Size = new System.Drawing.Size(82, 13);
            this.labelServidorEmail.TabIndex = 7;
            this.labelServidorEmail.Text = "Servidor SMTP:";
            // 
            // labelSenhaEmail
            // 
            this.labelSenhaEmail.AutoSize = true;
            this.labelSenhaEmail.Location = new System.Drawing.Point(7, 45);
            this.labelSenhaEmail.Name = "labelSenhaEmail";
            this.labelSenhaEmail.Size = new System.Drawing.Size(87, 13);
            this.labelSenhaEmail.TabIndex = 6;
            this.labelSenhaEmail.Text = "Senha do E-mail:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Enabled = false;
            this.textBoxUsuario.Location = new System.Drawing.Point(94, 101);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(474, 20);
            this.textBoxUsuario.TabIndex = 1;
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.Enabled = false;
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(94, 129);
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(474, 20);
            this.textBoxNomeUsuario.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Enabled = false;
            this.textBoxSenha.Location = new System.Drawing.Point(94, 157);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(474, 20);
            this.textBoxSenha.TabIndex = 3;
            this.textBoxSenha.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(94, 13);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(472, 20);
            this.textBoxEmail.TabIndex = 0;
            // 
            // textBoxSenhaEmail
            // 
            this.textBoxSenhaEmail.Enabled = false;
            this.textBoxSenhaEmail.Location = new System.Drawing.Point(94, 41);
            this.textBoxSenhaEmail.Name = "textBoxSenhaEmail";
            this.textBoxSenhaEmail.Size = new System.Drawing.Size(472, 20);
            this.textBoxSenhaEmail.TabIndex = 1;
            this.textBoxSenhaEmail.UseSystemPasswordChar = true;
            // 
            // textBoxPortaSmtp
            // 
            this.textBoxPortaSmtp.Enabled = false;
            this.textBoxPortaSmtp.Location = new System.Drawing.Point(448, 69);
            this.textBoxPortaSmtp.Name = "textBoxPortaSmtp";
            this.textBoxPortaSmtp.Size = new System.Drawing.Size(57, 20);
            this.textBoxPortaSmtp.TabIndex = 4;
            // 
            // textBoxServidorEmail
            // 
            this.textBoxServidorEmail.Enabled = false;
            this.textBoxServidorEmail.Location = new System.Drawing.Point(94, 69);
            this.textBoxServidorEmail.Name = "textBoxServidorEmail";
            this.textBoxServidorEmail.Size = new System.Drawing.Size(286, 20);
            this.textBoxServidorEmail.TabIndex = 2;
            // 
            // textBoxUsuarioEmail
            // 
            this.textBoxUsuarioEmail.Enabled = false;
            this.textBoxUsuarioEmail.Location = new System.Drawing.Point(94, 97);
            this.textBoxUsuarioEmail.Name = "textBoxUsuarioEmail";
            this.textBoxUsuarioEmail.Size = new System.Drawing.Size(472, 20);
            this.textBoxUsuarioEmail.TabIndex = 3;
            // 
            // groupBoxConfiguracaoEmail
            // 
            this.groupBoxConfiguracaoEmail.Controls.Add(this.checkBoxSsl);
            this.groupBoxConfiguracaoEmail.Controls.Add(this.labelEmail);
            this.groupBoxConfiguracaoEmail.Controls.Add(this.textBoxUsuarioEmail);
            this.groupBoxConfiguracaoEmail.Controls.Add(this.textBoxEmail);
            this.groupBoxConfiguracaoEmail.Controls.Add(this.textBoxPortaSmtp);
            this.groupBoxConfiguracaoEmail.Controls.Add(this.textBoxServidorEmail);
            this.groupBoxConfiguracaoEmail.Controls.Add(this.labelSenhaEmail);
            this.groupBoxConfiguracaoEmail.Controls.Add(this.labelUsuarioEmail);
            this.groupBoxConfiguracaoEmail.Controls.Add(this.textBoxSenhaEmail);
            this.groupBoxConfiguracaoEmail.Controls.Add(this.labelServidorEmail);
            this.groupBoxConfiguracaoEmail.Controls.Add(this.labelPortaSmtp);
            this.groupBoxConfiguracaoEmail.Location = new System.Drawing.Point(2, 185);
            this.groupBoxConfiguracaoEmail.Name = "groupBoxConfiguracaoEmail";
            this.groupBoxConfiguracaoEmail.Size = new System.Drawing.Size(572, 137);
            this.groupBoxConfiguracaoEmail.TabIndex = 8;
            this.groupBoxConfiguracaoEmail.TabStop = false;
            this.groupBoxConfiguracaoEmail.Text = "Configuração do E-mail";
            // 
            // checkBoxSsl
            // 
            this.checkBoxSsl.AutoSize = true;
            this.checkBoxSsl.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSsl.Location = new System.Drawing.Point(517, 71);
            this.checkBoxSsl.Name = "checkBoxSsl";
            this.checkBoxSsl.Size = new System.Drawing.Size(49, 17);
            this.checkBoxSsl.TabIndex = 10;
            this.checkBoxSsl.Text = "SSL:";
            this.checkBoxSsl.UseVisualStyleBackColor = true;
            // 
            // FormUsuarioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(579, 312);
            this.Controls.Add(this.groupBoxConfiguracaoEmail);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxNomeUsuario);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelNomeUsuario);
            this.Controls.Add(this.labelUsuario);
            this.Name = "FormUsuarioCadastro";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.FormUsuarioCadastro_Load);
            this.Controls.SetChildIndex(this.labelUsuario, 0);
            this.Controls.SetChildIndex(this.labelNomeUsuario, 0);
            this.Controls.SetChildIndex(this.labelSenha, 0);
            this.Controls.SetChildIndex(this.textBoxUsuario, 0);
            this.Controls.SetChildIndex(this.textBoxNomeUsuario, 0);
            this.Controls.SetChildIndex(this.textBoxSenha, 0);
            this.Controls.SetChildIndex(this.groupBoxConfiguracaoEmail, 0);
            this.Controls.SetChildIndex(this.panelControles, 0);
            this.Controls.SetChildIndex(this.panelNavegacao, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.panelControles.ResumeLayout(false);
            this.panelNavegacao.ResumeLayout(false);
            this.groupBoxConfiguracaoEmail.ResumeLayout(false);
            this.groupBoxConfiguracaoEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelNomeUsuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPortaSmtp;
        private System.Windows.Forms.Label labelUsuarioEmail;
        private System.Windows.Forms.Label labelServidorEmail;
        private System.Windows.Forms.Label labelSenhaEmail;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxNomeUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSenhaEmail;
        private System.Windows.Forms.TextBox textBoxPortaSmtp;
        private System.Windows.Forms.TextBox textBoxServidorEmail;
        private System.Windows.Forms.TextBox textBoxUsuarioEmail;
        private System.Windows.Forms.GroupBox groupBoxConfiguracaoEmail;
        private System.Windows.Forms.CheckBox checkBoxSsl;
    }
}
