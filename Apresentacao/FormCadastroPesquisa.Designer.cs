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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroPesquisa));
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelSql = new System.Windows.Forms.Label();
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.dataGridViewCamposPesquisa = new System.Windows.Forms.DataGridView();
            this.t02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCamposPesquisa = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.t01001cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t01002cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t01003nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.t01004nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.t01005cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t01006cDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControles.SuspendLayout();
            this.panelNavegacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamposPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCamposPesquisa)).BeginInit();
            this.bindingNavigatorCamposPesquisa.SuspendLayout();
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
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(218, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(356, 20);
            this.textBox3.TabIndex = 6;
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
            this.dataGridViewCamposPesquisa.AllowUserToOrderColumns = true;
            this.dataGridViewCamposPesquisa.AutoGenerateColumns = false;
            this.dataGridViewCamposPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamposPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t01001cDataGridViewTextBoxColumn,
            this.t01002cDataGridViewTextBoxColumn,
            this.t01003nDataGridViewTextBoxColumn,
            this.t01004nDataGridViewTextBoxColumn,
            this.t01005cDataGridViewTextBoxColumn,
            this.t01006cDataGridViewTextBoxColumn});
            this.dataGridViewCamposPesquisa.DataSource = this.t02BindingSource;
            this.dataGridViewCamposPesquisa.Enabled = false;
            this.dataGridViewCamposPesquisa.Location = new System.Drawing.Point(45, 444);
            this.dataGridViewCamposPesquisa.Name = "dataGridViewCamposPesquisa";
            this.dataGridViewCamposPesquisa.Size = new System.Drawing.Size(747, 207);
            this.dataGridViewCamposPesquisa.TabIndex = 9;
            // 
            // t02BindingSource
            // 
            this.t02BindingSource.DataSource = typeof(Repositorio.Entidades.T02);
            // 
            // bindingNavigatorCamposPesquisa
            // 
            this.bindingNavigatorCamposPesquisa.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorCamposPesquisa.BindingSource = this.t02BindingSource;
            this.bindingNavigatorCamposPesquisa.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorCamposPesquisa.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorCamposPesquisa.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorCamposPesquisa.Enabled = false;
            this.bindingNavigatorCamposPesquisa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorCamposPesquisa.Location = new System.Drawing.Point(45, 416);
            this.bindingNavigatorCamposPesquisa.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorCamposPesquisa.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorCamposPesquisa.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorCamposPesquisa.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorCamposPesquisa.Name = "bindingNavigatorCamposPesquisa";
            this.bindingNavigatorCamposPesquisa.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorCamposPesquisa.Size = new System.Drawing.Size(257, 25);
            this.bindingNavigatorCamposPesquisa.TabIndex = 11;
            this.bindingNavigatorCamposPesquisa.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // t01001cDataGridViewTextBoxColumn
            // 
            this.t01001cDataGridViewTextBoxColumn.DataPropertyName = "T01_001_c";
            this.t01001cDataGridViewTextBoxColumn.HeaderText = "Tabela";
            this.t01001cDataGridViewTextBoxColumn.Name = "t01001cDataGridViewTextBoxColumn";
            // 
            // t01002cDataGridViewTextBoxColumn
            // 
            this.t01002cDataGridViewTextBoxColumn.DataPropertyName = "T01_002_c";
            this.t01002cDataGridViewTextBoxColumn.HeaderText = "Campo";
            this.t01002cDataGridViewTextBoxColumn.Name = "t01002cDataGridViewTextBoxColumn";
            // 
            // t01003nDataGridViewTextBoxColumn
            // 
            this.t01003nDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t01003nDataGridViewTextBoxColumn.DataPropertyName = "T01_003_n";
            this.t01003nDataGridViewTextBoxColumn.HeaderText = "Operador";
            this.t01003nDataGridViewTextBoxColumn.Name = "t01003nDataGridViewTextBoxColumn";
            this.t01003nDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.t01003nDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // t01004nDataGridViewTextBoxColumn
            // 
            this.t01004nDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t01004nDataGridViewTextBoxColumn.DataPropertyName = "T01_004_n";
            this.t01004nDataGridViewTextBoxColumn.HeaderText = "Tipo do Campo";
            this.t01004nDataGridViewTextBoxColumn.Name = "t01004nDataGridViewTextBoxColumn";
            this.t01004nDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.t01004nDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // t01005cDataGridViewTextBoxColumn
            // 
            this.t01005cDataGridViewTextBoxColumn.DataPropertyName = "T01_005_c";
            this.t01005cDataGridViewTextBoxColumn.HeaderText = "Valor Padrão";
            this.t01005cDataGridViewTextBoxColumn.Name = "t01005cDataGridViewTextBoxColumn";
            // 
            // t01006cDataGridViewTextBoxColumn
            // 
            this.t01006cDataGridViewTextBoxColumn.DataPropertyName = "T01_006_c";
            this.t01006cDataGridViewTextBoxColumn.HeaderText = "Ordem";
            this.t01006cDataGridViewTextBoxColumn.Name = "t01006cDataGridViewTextBoxColumn";
            // 
            // FormCadastroPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(804, 663);
            this.Controls.Add(this.bindingNavigatorCamposPesquisa);
            this.Controls.Add(this.dataGridViewCamposPesquisa);
            this.Controls.Add(this.textBoxSQL);
            this.Controls.Add(this.labelSql);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.labelCodigo);
            this.Name = "FormCadastroPesquisa";
            this.Text = "T01";
            this.Load += new System.EventHandler(this.FormCadastroPesquisa_Load);
            this.Controls.SetChildIndex(this.panelControles, 0);
            this.Controls.SetChildIndex(this.panelNavegacao, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.labelCodigo, 0);
            this.Controls.SetChildIndex(this.labelDescricao, 0);
            this.Controls.SetChildIndex(this.textBoxCodigo, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.labelSql, 0);
            this.Controls.SetChildIndex(this.textBoxSQL, 0);
            this.Controls.SetChildIndex(this.dataGridViewCamposPesquisa, 0);
            this.Controls.SetChildIndex(this.bindingNavigatorCamposPesquisa, 0);
            this.panelControles.ResumeLayout(false);
            this.panelNavegacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamposPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t02BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorCamposPesquisa)).EndInit();
            this.bindingNavigatorCamposPesquisa.ResumeLayout(false);
            this.bindingNavigatorCamposPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelSql;
        private System.Windows.Forms.TextBox textBoxSQL;
        private System.Windows.Forms.DataGridView dataGridViewCamposPesquisa;
        private System.Windows.Forms.BindingSource t02BindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigatorCamposPesquisa;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn t01001cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t01002cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn t01003nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn t01004nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t01005cDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn t01006cDataGridViewTextBoxColumn;
    }
}
