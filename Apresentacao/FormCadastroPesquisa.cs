using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Repositorio.Entidades;

namespace Apresentacao
{
    public partial class FormCadastroPesquisa : Apresentacao.FormBase
    {
        public FormCadastroPesquisa()
        {
            InitializeComponent();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            novo();
        }

        private void novo()
        {
            Utils.habilitaCamposNovos(this);
        }

        private void FormCadastroPesquisa_Load(object sender, EventArgs e)
        {
            T02 t02 = new T02();

            t02.T01_001_c = "teste";

            t02BindingSource.Add(t02);
        }
    }
}
