namespace Apresentacao
{
    partial class FormBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.buttonRelatorio = new System.Windows.Forms.Button();
            this.buttonProximo = new System.Windows.Forms.Button();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.buttonUltimo = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.panelControles = new System.Windows.Forms.Panel();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.buttonDesfazer = new System.Windows.Forms.Button();
            this.panelNavegacao = new System.Windows.Forms.Panel();
            this.buttonPrimeiro = new System.Windows.Forms.Button();
            this.textBoxControles = new System.Windows.Forms.TextBox();
            this.toolTipFormBase = new System.Windows.Forms.ToolTip(this.components);
            this.panelControles.SuspendLayout();
            this.panelNavegacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRelatorio
            // 
            this.buttonRelatorio.Image = global::Apresentacao.Properties.Resources.Report_Card_25px;
            this.buttonRelatorio.Location = new System.Drawing.Point(4, 47);
            this.buttonRelatorio.Name = "buttonRelatorio";
            this.buttonRelatorio.Size = new System.Drawing.Size(65, 37);
            this.buttonRelatorio.TabIndex = 5;
            this.buttonRelatorio.UseVisualStyleBackColor = true;
            // 
            // buttonProximo
            // 
            this.buttonProximo.Image = global::Apresentacao.Properties.Resources.Down_2_25px;
            this.buttonProximo.Location = new System.Drawing.Point(119, 47);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(38, 38);
            this.buttonProximo.TabIndex = 1;
            this.buttonProximo.UseVisualStyleBackColor = true;
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.Image = global::Apresentacao.Properties.Resources.Search_25px;
            this.buttonPesquisa.Location = new System.Drawing.Point(4, 3);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(65, 38);
            this.buttonPesquisa.TabIndex = 1;
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            // 
            // buttonUltimo
            // 
            this.buttonUltimo.Image = global::Apresentacao.Properties.Resources.right_round_25px;
            this.buttonUltimo.Location = new System.Drawing.Point(119, 3);
            this.buttonUltimo.Name = "buttonUltimo";
            this.buttonUltimo.Size = new System.Drawing.Size(38, 38);
            this.buttonUltimo.TabIndex = 4;
            this.buttonUltimo.UseVisualStyleBackColor = true;
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Image = global::Apresentacao.Properties.Resources.Down_3_25px;
            this.buttonAnterior.Location = new System.Drawing.Point(75, 47);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(38, 38);
            this.buttonAnterior.TabIndex = 2;
            this.buttonAnterior.UseVisualStyleBackColor = true;
            // 
            // panelControles
            // 
            this.panelControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelControles.Controls.Add(this.buttonSalvar);
            this.panelControles.Controls.Add(this.buttonNovo);
            this.panelControles.Controls.Add(this.buttonEditar);
            this.panelControles.Controls.Add(this.buttonExcluir);
            this.panelControles.Controls.Add(this.buttonSair);
            this.panelControles.Controls.Add(this.buttonDesfazer);
            this.panelControles.Location = new System.Drawing.Point(174, 2);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(400, 67);
            this.panelControles.TabIndex = 0;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Image = global::Apresentacao.Properties.Resources.Save_25px;
            this.buttonSalvar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSalvar.Location = new System.Drawing.Point(137, 3);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(59, 59);
            this.buttonSalvar.TabIndex = 1;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Image = global::Apresentacao.Properties.Resources.Plus_25px;
            this.buttonNovo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonNovo.Location = new System.Drawing.Point(3, 3);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(59, 59);
            this.buttonNovo.TabIndex = 0;
            this.buttonNovo.Text = "Novo";
            this.buttonNovo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Enabled = false;
            this.buttonEditar.Image = global::Apresentacao.Properties.Resources.Edit_25px;
            this.buttonEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonEditar.Location = new System.Drawing.Point(70, 3);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(59, 59);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEditar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Enabled = false;
            this.buttonExcluir.Image = global::Apresentacao.Properties.Resources.Delete_25px;
            this.buttonExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonExcluir.Location = new System.Drawing.Point(204, 3);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(59, 59);
            this.buttonExcluir.TabIndex = 4;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonSair
            // 
            this.buttonSair.Image = global::Apresentacao.Properties.Resources.Exit_25px;
            this.buttonSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSair.Location = new System.Drawing.Point(338, 3);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(59, 59);
            this.buttonSair.TabIndex = 2;
            this.buttonSair.Text = "Sair";
            this.buttonSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // buttonDesfazer
            // 
            this.buttonDesfazer.Enabled = false;
            this.buttonDesfazer.Image = global::Apresentacao.Properties.Resources.Rotate_Left_25px;
            this.buttonDesfazer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDesfazer.Location = new System.Drawing.Point(271, 3);
            this.buttonDesfazer.Name = "buttonDesfazer";
            this.buttonDesfazer.Size = new System.Drawing.Size(59, 59);
            this.buttonDesfazer.TabIndex = 5;
            this.buttonDesfazer.Text = "Desfazer";
            this.buttonDesfazer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDesfazer.UseVisualStyleBackColor = true;
            this.buttonDesfazer.Click += new System.EventHandler(this.buttonDesfazer_Click);
            // 
            // panelNavegacao
            // 
            this.panelNavegacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNavegacao.Controls.Add(this.buttonPrimeiro);
            this.panelNavegacao.Controls.Add(this.buttonAnterior);
            this.panelNavegacao.Controls.Add(this.buttonUltimo);
            this.panelNavegacao.Controls.Add(this.buttonProximo);
            this.panelNavegacao.Controls.Add(this.buttonPesquisa);
            this.panelNavegacao.Controls.Add(this.buttonRelatorio);
            this.panelNavegacao.Location = new System.Drawing.Point(2, 2);
            this.panelNavegacao.Name = "panelNavegacao";
            this.panelNavegacao.Size = new System.Drawing.Size(166, 89);
            this.panelNavegacao.TabIndex = 2;
            // 
            // buttonPrimeiro
            // 
            this.buttonPrimeiro.Image = global::Apresentacao.Properties.Resources.left_round_25px;
            this.buttonPrimeiro.Location = new System.Drawing.Point(75, 3);
            this.buttonPrimeiro.Name = "buttonPrimeiro";
            this.buttonPrimeiro.Size = new System.Drawing.Size(38, 38);
            this.buttonPrimeiro.TabIndex = 3;
            this.buttonPrimeiro.UseVisualStyleBackColor = true;
            // 
            // textBoxControles
            // 
            this.textBoxControles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxControles.Location = new System.Drawing.Point(174, 71);
            this.textBoxControles.Name = "textBoxControles";
            this.textBoxControles.Size = new System.Drawing.Size(400, 20);
            this.textBoxControles.TabIndex = 1;
            this.textBoxControles.Text = "Controles";
            this.textBoxControles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolTipFormBase
            // 
            this.toolTipFormBase.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipFormBase.ToolTipTitle = "Dica!";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 410);
            this.Controls.Add(this.textBoxControles);
            this.Controls.Add(this.panelNavegacao);
            this.Controls.Add(this.panelControles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.panelControles.ResumeLayout(false);
            this.panelNavegacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button buttonNovo;
        public System.Windows.Forms.Button buttonRelatorio;
        public System.Windows.Forms.Button buttonProximo;
        public System.Windows.Forms.Button buttonPesquisa;
        public System.Windows.Forms.Button buttonUltimo;
        public System.Windows.Forms.Button buttonPrimeiro;
        public System.Windows.Forms.Button buttonAnterior;
        public System.Windows.Forms.Button buttonSair;
        public System.Windows.Forms.Button buttonDesfazer;
        public System.Windows.Forms.Button buttonExcluir;
        public System.Windows.Forms.Button buttonEditar;
        public System.Windows.Forms.Panel panelControles;
        public System.Windows.Forms.Panel panelNavegacao;
        public System.Windows.Forms.TextBox textBoxControles;
        public System.Windows.Forms.ToolTip toolTipFormBase;
        public System.Windows.Forms.Button buttonSalvar;
    }
}