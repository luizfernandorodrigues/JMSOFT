namespace Apresentacao
{
    partial class FormCadastroPesquisa
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
            this.components = new System.ComponentModel.Container();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.labelSql = new System.Windows.Forms.Label();
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.dataGridViewCamposPesquisa = new System.Windows.Forms.DataGridView();
            this.t02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.t01001cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t01002cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t01003nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t01004nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t01006cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonIncluirCampoPesquisa = new System.Windows.Forms.Button();
            this.buttonEditarCampoPesquisa = new System.Windows.Forms.Button();
            this.buttonVisualizacampoPesquisa = new System.Windows.Forms.Button();
            this.buttonExcluiCampoPesquisa = new System.Windows.Forms.Button();
            this.panelControles.SuspendLayout();
            this.panelNavegacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamposPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNovo
            // 
            this.toolTipFormBase.SetToolTip(this.buttonNovo, "Adicionar Registro!");
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
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
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Location = new System.Drawing.Point(2, 108);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(43, 13);
            this.labelCodigo.TabIndex = 3;
            this.labelCodigo.Text = "Código:";
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(160, 108);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(58, 13);
            this.labelDescricao.TabIndex = 4;
            this.labelDescricao.Text = "Descrição:";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Location = new System.Drawing.Point(45, 104);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(115, 20);
            this.textBoxCodigo.TabIndex = 5;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Enabled = false;
            this.textBoxDescricao.Location = new System.Drawing.Point(218, 104);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(356, 20);
            this.textBoxDescricao.TabIndex = 6;
            // 
            // labelSql
            // 
            this.labelSql.AutoSize = true;
            this.labelSql.Location = new System.Drawing.Point(17, 266);
            this.labelSql.Name = "labelSql";
            this.labelSql.Size = new System.Drawing.Size(28, 13);
            this.labelSql.TabIndex = 7;
            this.labelSql.Text = "SQL";
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.Enabled = false;
            this.textBoxSQL.Location = new System.Drawing.Point(45, 131);
            this.textBoxSQL.Multiline = true;
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.Size = new System.Drawing.Size(747, 282);
            this.textBoxSQL.TabIndex = 8;
            // 
            // dataGridViewCamposPesquisa
            // 
            this.dataGridViewCamposPesquisa.AllowUserToAddRows = false;
            this.dataGridViewCamposPesquisa.AllowUserToDeleteRows = false;
            this.dataGridViewCamposPesquisa.AllowUserToOrderColumns = true;
            this.dataGridViewCamposPesquisa.AutoGenerateColumns = false;
            this.dataGridViewCamposPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamposPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t01001cDataGridViewTextBoxColumn,
            this.t01002cDataGridViewTextBoxColumn,
            this.t01003nDataGridViewTextBoxColumn,
            this.t01004nDataGridViewTextBoxColumn,
            this.t01006cDataGridViewTextBoxColumn});
            this.dataGridViewCamposPesquisa.DataSource = this.t02BindingSource;
            this.dataGridViewCamposPesquisa.Enabled = false;
            this.dataGridViewCamposPesquisa.Location = new System.Drawing.Point(45, 444);
            this.dataGridViewCamposPesquisa.Name = "dataGridViewCamposPesquisa";
            this.dataGridViewCamposPesquisa.ReadOnly = true;
            this.dataGridViewCamposPesquisa.Size = new System.Drawing.Size(747, 207);
            this.dataGridViewCamposPesquisa.TabIndex = 9;
            // 
            // t02BindingSource
            // 
            this.t02BindingSource.DataSource = typeof(Repositorio.Entidades.T02);
            // 
            // t01001cDataGridViewTextBoxColumn
            // 
            this.t01001cDataGridViewTextBoxColumn.DataPropertyName = "T02_001_c";
            this.t01001cDataGridViewTextBoxColumn.HeaderText = "Tabela";
            this.t01001cDataGridViewTextBoxColumn.Name = "t01001cDataGridViewTextBoxColumn";
            this.t01001cDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // t01002cDataGridViewTextBoxColumn
            // 
            this.t01002cDataGridViewTextBoxColumn.DataPropertyName = "T02_002_c";
            this.t01002cDataGridViewTextBoxColumn.HeaderText = "Campo";
            this.t01002cDataGridViewTextBoxColumn.Name = "t01002cDataGridViewTextBoxColumn";
            this.t01002cDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // t01003nDataGridViewTextBoxColumn
            // 
            this.t01003nDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t01003nDataGridViewTextBoxColumn.DataPropertyName = "T02_003_n";
            this.t01003nDataGridViewTextBoxColumn.HeaderText = "Operador";
            this.t01003nDataGridViewTextBoxColumn.Name = "t01003nDataGridViewTextBoxColumn";
            this.t01003nDataGridViewTextBoxColumn.ReadOnly = true;
            this.t01003nDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // t01004nDataGridViewTextBoxColumn
            // 
            this.t01004nDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t01004nDataGridViewTextBoxColumn.DataPropertyName = "T02_004_n";
            this.t01004nDataGridViewTextBoxColumn.HeaderText = "Tipo do Campo";
            this.t01004nDataGridViewTextBoxColumn.Name = "t01004nDataGridViewTextBoxColumn";
            this.t01004nDataGridViewTextBoxColumn.ReadOnly = true;
            this.t01004nDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // t01006cDataGridViewTextBoxColumn
            // 
            this.t01006cDataGridViewTextBoxColumn.DataPropertyName = "T02_006_c";
            this.t01006cDataGridViewTextBoxColumn.HeaderText = "Ordem";
            this.t01006cDataGridViewTextBoxColumn.Name = "t01006cDataGridViewTextBoxColumn";
            this.t01006cDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonIncluirCampoPesquisa
            // 
            this.buttonIncluirCampoPesquisa.Image = global::Apresentacao.Properties.Resources.Add_List_15px;
            this.buttonIncluirCampoPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIncluirCampoPesquisa.Location = new System.Drawing.Point(45, 419);
            this.buttonIncluirCampoPesquisa.Name = "buttonIncluirCampoPesquisa";
            this.buttonIncluirCampoPesquisa.Size = new System.Drawing.Size(71, 23);
            this.buttonIncluirCampoPesquisa.TabIndex = 10;
            this.buttonIncluirCampoPesquisa.Text = "Incluir";
            this.buttonIncluirCampoPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIncluirCampoPesquisa.UseVisualStyleBackColor = true;
            // 
            // buttonEditarCampoPesquisa
            // 
            this.buttonEditarCampoPesquisa.Image = global::Apresentacao.Properties.Resources.Edit_Property_15px;
            this.buttonEditarCampoPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEditarCampoPesquisa.Location = new System.Drawing.Point(124, 419);
            this.buttonEditarCampoPesquisa.Name = "buttonEditarCampoPesquisa";
            this.buttonEditarCampoPesquisa.Size = new System.Drawing.Size(71, 23);
            this.buttonEditarCampoPesquisa.TabIndex = 11;
            this.buttonEditarCampoPesquisa.Text = "Alterar";
            this.buttonEditarCampoPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonEditarCampoPesquisa.UseVisualStyleBackColor = true;
            // 
            // buttonVisualizacampoPesquisa
            // 
            this.buttonVisualizacampoPesquisa.Image = global::Apresentacao.Properties.Resources.Delete_Property_15px;
            this.buttonVisualizacampoPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVisualizacampoPesquisa.Location = new System.Drawing.Point(203, 419);
            this.buttonVisualizacampoPesquisa.Name = "buttonVisualizacampoPesquisa";
            this.buttonVisualizacampoPesquisa.Size = new System.Drawing.Size(71, 23);
            this.buttonVisualizacampoPesquisa.TabIndex = 12;
            this.buttonVisualizacampoPesquisa.Text = "Excluir";
            this.buttonVisualizacampoPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonVisualizacampoPesquisa.UseVisualStyleBackColor = true;
            // 
            // buttonExcluiCampoPesquisa
            // 
            this.buttonExcluiCampoPesquisa.Image = global::Apresentacao.Properties.Resources.Search_15px_1;
            this.buttonExcluiCampoPesquisa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluiCampoPesquisa.Location = new System.Drawing.Point(282, 419);
            this.buttonExcluiCampoPesquisa.Name = "buttonExcluiCampoPesquisa";
            this.buttonExcluiCampoPesquisa.Size = new System.Drawing.Size(71, 23);
            this.buttonExcluiCampoPesquisa.TabIndex = 13;
            this.buttonExcluiCampoPesquisa.Text = "Visualizar";
            this.buttonExcluiCampoPesquisa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluiCampoPesquisa.UseVisualStyleBackColor = true;
            // 
            // FormCadastroPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(804, 663);
            this.Controls.Add(this.buttonExcluiCampoPesquisa);
            this.Controls.Add(this.buttonVisualizacampoPesquisa);
            this.Controls.Add(this.buttonEditarCampoPesquisa);
            this.Controls.Add(this.buttonIncluirCampoPesquisa);
            this.Controls.Add(this.dataGridViewCamposPesquisa);
            this.Controls.Add(this.textBoxSQL);
            this.Controls.Add(this.labelSql);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelCodigo);
            this.Name = "FormCadastroPesquisa";
            this.Text = "T01";
            this.Controls.SetChildIndex(this.textBoxControles, 0);
            this.Controls.SetChildIndex(this.panelControles, 0);
            this.Controls.SetChildIndex(this.panelNavegacao, 0);
            this.Controls.SetChildIndex(this.labelCodigo, 0);
            this.Controls.SetChildIndex(this.labelDescricao, 0);
            this.Controls.SetChildIndex(this.textBoxCodigo, 0);
            this.Controls.SetChildIndex(this.textBoxDescricao, 0);
            this.Controls.SetChildIndex(this.labelSql, 0);
            this.Controls.SetChildIndex(this.textBoxSQL, 0);
            this.Controls.SetChildIndex(this.dataGridViewCamposPesquisa, 0);
            this.Controls.SetChildIndex(this.buttonIncluirCampoPesquisa, 0);
            this.Controls.SetChildIndex(this.buttonEditarCampoPesquisa, 0);
            this.Controls.SetChildIndex(this.buttonVisualizacampoPesquisa, 0);
            this.Controls.SetChildIndex(this.buttonExcluiCampoPesquisa, 0);
            this.panelControles.ResumeLayout(false);
            this.panelNavegacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamposPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.Label labelSql;
        private System.Windows.Forms.TextBox textBoxSQL;
        private System.Windows.Forms.DataGridView dataGridViewCamposPesquisa;
        private System.Windows.Forms.BindingSource t02BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn t01001cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t01002cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t01003nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t01004nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t01006cDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonIncluirCampoPesquisa;
        private System.Windows.Forms.Button buttonEditarCampoPesquisa;
        private System.Windows.Forms.Button buttonVisualizacampoPesquisa;
        private System.Windows.Forms.Button buttonExcluiCampoPesquisa;
    }
}
