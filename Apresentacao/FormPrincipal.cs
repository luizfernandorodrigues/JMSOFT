﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = Utils.TITULO;
            this.toolStripStatusLabel1.Text = Utils.VERSAO;
        }

        /// <summary>
        /// Função do botão sair, exibe uma mensagem para o usuário se deseja reamente sair do sistema, caso resultado seja sim 
        /// a aplicação é fechada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mensagem = MessageBox.Show("Deseja Realmente Sair do Sistema?", Utils.TITULO, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (mensagem == DialogResult.No)
            {
                return;
            }

            Application.Exit();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarioCadastro frm = new FormUsuarioCadastro();
            frm.Show();
        }

        private void cadastroDePesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPesquisa frm = new FormCadastroPesquisa();
            frm.Show();
        }
    }
}
